package com.unity3d.player;

import android.app.ProgressDialog;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.util.Log;
import com.byazt.tk.AdBaseConstants;
import com.gorilla.appdownload.IDownloadProgress;
import com.gorilla.appdownload.IDownloadResult;
import com.gorilla.base.Api;
import com.gorilla.base.util.GorillaFileProviderUtils;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URI;
import java.net.URL;
import java.security.MessageDigest;
import java.util.Locale;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import kotlin.UByte;

/* JADX INFO: loaded from: classes4.dex */
public class DxxUnityActivity extends UnityPlayerActivity {
    private static final int ALREADY_RUNNING = 1;
    private static final int BUFFER_SIZE = 65536;
    private static final String DOWNLOAD_DIRECTORY = "gorilla_app_download_resume";
    private static final String DOWNLOAD_PREFERENCES = "gorilla_app_download_resume_state";
    private static final String PREF_ETAG = "etag";
    private static final String PREF_IDENTITY = "identity";
    private static final String PREF_LAST_MODIFIED = "last_modified";
    private static final String PREF_TOTAL_BYTES = "total_bytes";
    private static final int REPLACED_PREVIOUS = 2;
    private static final int REQUEST_INSTALL_UNKNOWN_APPS = 9327;
    private static final int RESULT_DOWNLOAD_COMPLETE = 0;
    private static final int RESULT_FAILED = -1;
    private static final int RESULT_INSTALL_STARTED = 1;
    private static final int STARTED = 0;
    private static final int START_INVALID = -1;
    private static final String TAG = "DxxUnityActivity";
    private HttpURLConnection activeConnection;
    private int downloadGeneration;
    private boolean downloadRunning;
    private File pendingInstallFile;
    private IDownloadProgress progressCallback;
    private ProgressDialog progressDialog;
    private IDownloadResult resultCallback;
    private final Object downloadLock = new Object();
    private final ExecutorService downloadExecutor = Executors.newFixedThreadPool(2);
    private String activeIdentity = "";
    private int lastProgress = -1;
    private int pendingInstallGeneration = -1;

    private String valueOrEmpty(String str) {
        return str == null ? "" : str;
    }

    @Override // android.app.Activity
    public void onBackPressed() {
    }

    @Override // com.unity3d.player.UnityPlayerActivity, android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        Log.d(TAG, "onCreate called");
    }

    @Override // com.unity3d.player.UnityPlayerActivity, android.app.Activity
    protected void onDestroy() {
        synchronized (this.downloadLock) {
            this.downloadGeneration++;
            this.downloadRunning = false;
            this.activeIdentity = "";
            HttpURLConnection httpURLConnection = this.activeConnection;
            if (httpURLConnection != null) {
                httpURLConnection.disconnect();
                this.activeConnection = null;
            }
        }
        this.downloadExecutor.shutdownNow();
        dismissProgressDialog();
        super.onDestroy();
    }

    @Override // android.app.Activity
    protected void onActivityResult(int i, int i2, Intent intent) {
        super.onActivityResult(i, i2, intent);
        Api.onActivityResult(i, i2, intent);
        if (i != REQUEST_INSTALL_UNKNOWN_APPS) {
            return;
        }
        File file = this.pendingInstallFile;
        int i3 = this.pendingInstallGeneration;
        this.pendingInstallFile = null;
        this.pendingInstallGeneration = -1;
        if (!isCurrentDownload(i3) || file == null) {
            return;
        }
        if (getPackageManager().canRequestPackageInstalls()) {
            launchPackageInstaller(file, i3);
        } else {
            failCurrentDownload(i3, "install permission denied");
        }
    }

    public int startResumableApkDownload(final String str, String str2, final boolean z, final boolean z2, IDownloadResult iDownloadResult, IDownloadProgress iDownloadProgress) {
        if (!isValidHttpUrl(str)) {
            notifyResult(iDownloadResult, -1, "invalid update url");
            return -1;
        }
        final String strCreateDownloadIdentity = createDownloadIdentity(str, str2);
        if (strCreateDownloadIdentity.length() == 0) {
            notifyResult(iDownloadResult, -1, "failed to create download identity");
            return -1;
        }
        synchronized (this.downloadLock) {
            this.resultCallback = iDownloadResult;
            this.progressCallback = iDownloadProgress;
            if (this.downloadRunning && strCreateDownloadIdentity.equals(this.activeIdentity)) {
                return 1;
            }
            boolean z3 = this.downloadRunning && !strCreateDownloadIdentity.equals(this.activeIdentity);
            final int i = this.downloadGeneration + 1;
            this.downloadGeneration = i;
            this.downloadRunning = true;
            this.activeIdentity = strCreateDownloadIdentity;
            this.lastProgress = -1;
            this.pendingInstallFile = null;
            this.pendingInstallGeneration = -1;
            HttpURLConnection httpURLConnection = this.activeConnection;
            if (httpURLConnection != null) {
                httpURLConnection.disconnect();
                this.activeConnection = null;
            }
            this.downloadExecutor.execute(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda3
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.m275x1db07d38(str, strCreateDownloadIdentity, i, z, z2);
                }
            });
            return z3 ? 2 : 0;
        }
    }

    public boolean isResumableApkDownloadRunning() {
        boolean z;
        synchronized (this.downloadLock) {
            z = this.downloadRunning;
        }
        return z;
    }

    public void cleanResumableApkDownloads() {
        synchronized (this.downloadLock) {
            if (this.downloadRunning) {
                return;
            }
            cleanOtherDownloadFiles(getDownloadDirectory(), null, null);
            getDownloadPreferences().edit().clear().apply();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX INFO: renamed from: runDownload, reason: merged with bridge method [inline-methods] */
    public void m275x1db07d38(String str, String str2, int i, boolean z, boolean z2) {
        try {
            ensureCurrentDownload(i);
            File downloadDirectory = getDownloadDirectory();
            if (!downloadDirectory.exists() && !downloadDirectory.mkdirs()) {
                throw new IOException("download directory is unavailable");
            }
            File file = new File(downloadDirectory, str2 + ".part");
            File file2 = new File(downloadDirectory, str2 + ".apk");
            cleanOtherDownloadFiles(downloadDirectory, file, file2);
            prepareResumeState(str2);
            if (z) {
                showProgressDialog(i);
            }
            if (file2.isFile()) {
                if (isValidApk(file2)) {
                    notifyProgress(i, 100);
                    notifyCurrentResult(i, 0, "download complete");
                    requestPackageInstall(file2, i, z2);
                    return;
                }
                deleteFile(file2);
            }
            downloadToPartialFile(str, str2, file, i);
            ensureCurrentDownload(i);
            promotePartialFile(file, file2);
            if (!isValidApk(file2)) {
                deleteFile(file2);
                clearResumeState(str2);
                throw new IOException("downloaded apk is invalid");
            }
            notifyProgress(i, 100);
            notifyCurrentResult(i, 0, "download complete");
            requestPackageInstall(file2, i, z2);
        } catch (DownloadReplacedException unused) {
        } catch (Exception e) {
            if (isCurrentDownload(i)) {
                Log.e(TAG, "APK download failed: " + e.getClass().getSimpleName());
                failCurrentDownload(i, toSafeFailureMessage(e));
            }
        }
    }

    private void downloadToPartialFile(String str, String str2, File file, int i) throws Exception {
        HttpURLConnection httpURLConnection;
        boolean z = false;
        while (true) {
            ensureCurrentDownload(i);
            long length = file.isFile() ? file.length() : 0L;
            SharedPreferences downloadPreferences = getDownloadPreferences();
            String string = downloadPreferences.getString("etag", "");
            String string2 = downloadPreferences.getString(PREF_LAST_MODIFIED, "");
            long j = downloadPreferences.getLong(PREF_TOTAL_BYTES, -1L);
            httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
            httpURLConnection.setConnectTimeout(15000);
            httpURLConnection.setReadTimeout(KSImageLoader.InnerImageLoadingListener.MAX_DURATION);
            httpURLConnection.setInstanceFollowRedirects(true);
            httpURLConnection.setRequestProperty("Accept-Encoding", PREF_IDENTITY);
            if (length > 0) {
                httpURLConnection.setRequestProperty(com.sigmob.sdk.downloader.core.c.b, "bytes=" + length + "-");
                if (string.length() > 0) {
                    httpURLConnection.setRequestProperty("If-Range", string);
                } else if (string2.length() > 0) {
                    httpURLConnection.setRequestProperty("If-Range", string2);
                }
            }
            setActiveConnection(httpURLConnection, i);
            try {
                int responseCode = httpURLConnection.getResponseCode();
                ensureCurrentDownload(i);
                if (responseCode == 416) {
                    if (length > 0 && j > 0 && length == j) {
                        break;
                    }
                    if (z) {
                        throw new HttpStatusException(responseCode);
                    }
                    deleteFile(file);
                    resetResumeHeaders(str2);
                    clearActiveConnection(httpURLConnection);
                    httpURLConnection.disconnect();
                    z = true;
                } else {
                    if (length <= 0 || responseCode != 200) {
                        if (responseCode != 200 && responseCode != 206) {
                            throw new HttpStatusException(responseCode);
                        }
                        boolean z2 = length > 0 && responseCode == 206;
                        if (!z2) {
                            length = 0;
                        }
                        long jResolveTotalBytes = resolveTotalBytes(httpURLConnection, responseCode, length);
                        saveResumeHeaders(str2, httpURLConnection, jResolveTotalBytes);
                        notifyProgress(i, calculateProgress(length, jResolveTotalBytes));
                        BufferedInputStream bufferedInputStream = new BufferedInputStream(httpURLConnection.getInputStream(), 65536);
                        try {
                            BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(new FileOutputStream(file, z2), 65536);
                            try {
                                byte[] bArr = new byte[65536];
                                while (true) {
                                    int i2 = bufferedInputStream.read(bArr);
                                    if (i2 == -1) {
                                        break;
                                    }
                                    ensureCurrentDownload(i);
                                    bufferedOutputStream.write(bArr, 0, i2);
                                    length += (long) i2;
                                    notifyProgress(i, calculateProgress(length, jResolveTotalBytes));
                                    try {
                                        bufferedInputStream.close();
                                        throw th;
                                    } catch (Throwable th) {
                                        th.addSuppressed(th);
                                        throw th;
                                    }
                                }
                                bufferedOutputStream.flush();
                                bufferedOutputStream.close();
                                bufferedInputStream.close();
                                if (jResolveTotalBytes > 0 && length < jResolveTotalBytes) {
                                    throw new EOFException("download ended before content length");
                                }
                                if (jResolveTotalBytes <= 0 || length <= jResolveTotalBytes) {
                                    break;
                                    break;
                                }
                                throw new IOException("download exceeded content length");
                            } catch (Throwable th2) {
                                try {
                                    bufferedOutputStream.close();
                                    throw th2;
                                } catch (Throwable th3) {
                                    th2.addSuppressed(th3);
                                    throw th2;
                                }
                            }
                        } catch (Throwable th4) {
                            bufferedInputStream.close();
                            throw th4;
                        }
                    }
                    if (z) {
                        throw new IOException("server does not support a stable range response");
                    }
                    deleteFile(file);
                    resetResumeHeaders(str2);
                    clearActiveConnection(httpURLConnection);
                    httpURLConnection.disconnect();
                    z = true;
                }
            } catch (Throwable th5) {
                clearActiveConnection(httpURLConnection);
                httpURLConnection.disconnect();
                throw th5;
            }
        }
        clearActiveConnection(httpURLConnection);
        httpURLConnection.disconnect();
    }

    private void requestPackageInstall(final File file, final int i, final boolean z) {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.m273x8f35f6c9(i, z, file);
            }
        });
    }

    /* JADX INFO: renamed from: lambda$requestPackageInstall$1$com-unity3d-player-DxxUnityActivity, reason: not valid java name */
    /* synthetic */ void m273x8f35f6c9(int i, boolean z, File file) {
        if (isCurrentDownload(i)) {
            dismissProgressDialog();
            if (getPackageManager().canRequestPackageInstalls()) {
                launchPackageInstaller(file, i);
                return;
            }
            if (!z) {
                failCurrentDownload(i, "install permission denied");
                return;
            }
            this.pendingInstallFile = file;
            this.pendingInstallGeneration = i;
            try {
                Intent intent = new Intent("android.settings.MANAGE_UNKNOWN_APP_SOURCES");
                intent.setData(Uri.parse("package:" + getPackageName()));
                startActivityForResult(intent, REQUEST_INSTALL_UNKNOWN_APPS);
            } catch (Exception unused) {
                this.pendingInstallFile = null;
                this.pendingInstallGeneration = -1;
                failCurrentDownload(i, "failed to request install permission");
            }
        }
    }

    private void launchPackageInstaller(File file, int i) {
        if (isCurrentDownload(i)) {
            try {
                if (!isValidApk(file)) {
                    deleteFile(file);
                    clearResumeState(this.activeIdentity);
                    throw new IOException("apk validation failed before install");
                }
                Uri uriForFile = GorillaFileProviderUtils.getUriForFile(this, file);
                if (uriForFile == null) {
                    throw new IOException("apk uri is unavailable");
                }
                Intent intent = new Intent("android.intent.action.VIEW");
                intent.setDataAndType(uriForFile, AdBaseConstants.MIME_APK);
                intent.addFlags(1);
                intent.addFlags(com.bykv.vk.component.ttvideo.player.C.ENCODING_PCM_MU_LAW);
                startActivity(intent);
                finishCurrentDownload(i);
                notifyCurrentResult(i, 1, "start install apk");
            } catch (Exception unused) {
                failCurrentDownload(i, "failed to start apk installer");
            }
        }
    }

    private boolean isValidApk(File file) {
        PackageInfo packageArchiveInfo;
        if (file == null || !file.isFile() || file.length() <= 0) {
            return false;
        }
        PackageManager packageManager = getPackageManager();
        if (Build.VERSION.SDK_INT >= 33) {
            packageArchiveInfo = packageManager.getPackageArchiveInfo(file.getAbsolutePath(), PackageManager.PackageInfoFlags.of(0L));
        } else {
            packageArchiveInfo = packageManager.getPackageArchiveInfo(file.getAbsolutePath(), 0);
        }
        return packageArchiveInfo != null && getPackageName().equals(packageArchiveInfo.packageName);
    }

    private void prepareResumeState(String str) {
        SharedPreferences downloadPreferences = getDownloadPreferences();
        if (str.equals(downloadPreferences.getString(PREF_IDENTITY, ""))) {
            return;
        }
        downloadPreferences.edit().clear().putString(PREF_IDENTITY, str).apply();
    }

    private void saveResumeHeaders(String str, HttpURLConnection httpURLConnection, long j) {
        String strValueOrEmpty = valueOrEmpty(httpURLConnection.getHeaderField("ETag"));
        getDownloadPreferences().edit().putString(PREF_IDENTITY, str).putString("etag", strValueOrEmpty).putString(PREF_LAST_MODIFIED, valueOrEmpty(httpURLConnection.getHeaderField("Last-Modified"))).putLong(PREF_TOTAL_BYTES, j).apply();
    }

    private void resetResumeHeaders(String str) {
        getDownloadPreferences().edit().clear().putString(PREF_IDENTITY, str).apply();
    }

    private void clearResumeState(String str) {
        SharedPreferences downloadPreferences = getDownloadPreferences();
        if (str == null || !str.equals(downloadPreferences.getString(PREF_IDENTITY, ""))) {
            return;
        }
        downloadPreferences.edit().clear().apply();
    }

    private SharedPreferences getDownloadPreferences() {
        return getSharedPreferences(DOWNLOAD_PREFERENCES, 0);
    }

    private File getDownloadDirectory() {
        return new File(getFilesDir(), DOWNLOAD_DIRECTORY);
    }

    private void cleanOtherDownloadFiles(File file, File file2, File file3) {
        File[] fileArrListFiles = file.listFiles();
        if (fileArrListFiles == null) {
            return;
        }
        for (File file4 : fileArrListFiles) {
            if (file4.isFile() && ((file2 == null || !file4.equals(file2)) && (file3 == null || !file4.equals(file3)))) {
                String lowerCase = file4.getName().toLowerCase(Locale.ROOT);
                if (lowerCase.endsWith(".part") || lowerCase.endsWith(".apk")) {
                    deleteFile(file4);
                }
            }
        }
    }

    private void promotePartialFile(File file, File file2) throws IOException {
        if (!file.isFile() || file.length() <= 0) {
            throw new IOException("partial apk is unavailable");
        }
        deleteFile(file2);
        if (file.renameTo(file2)) {
            return;
        }
        BufferedInputStream bufferedInputStream = new BufferedInputStream(new FileInputStream(file), 65536);
        try {
            BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(new FileOutputStream(file2), 65536);
            try {
                byte[] bArr = new byte[65536];
                while (true) {
                    int i = bufferedInputStream.read(bArr);
                    if (i == -1) {
                        break;
                    } else {
                        bufferedOutputStream.write(bArr, 0, i);
                    }
                    try {
                        bufferedInputStream.close();
                    } catch (Throwable th) {
                        th.addSuppressed(th);
                    }
                    throw th;
                }
                bufferedOutputStream.flush();
                bufferedOutputStream.close();
                bufferedInputStream.close();
                if (file.delete()) {
                    return;
                }
                deleteFile(file2);
                throw new IOException("failed to remove partial apk");
            } catch (Throwable th2) {
                try {
                    bufferedOutputStream.close();
                } catch (Throwable th3) {
                    th2.addSuppressed(th3);
                }
                throw th2;
            }
        } catch (Throwable th4) {
            bufferedInputStream.close();
            throw th4;
        }
    }

    private long resolveTotalBytes(HttpURLConnection httpURLConnection, int i, long j) {
        String headerField;
        int iLastIndexOf;
        int i2;
        if (i == 206 && (headerField = httpURLConnection.getHeaderField(com.sigmob.sdk.downloader.core.c.f)) != null && (iLastIndexOf = headerField.lastIndexOf(47)) >= 0 && (i2 = iLastIndexOf + 1) < headerField.length()) {
            long positiveLong = parsePositiveLong(headerField.substring(i2));
            if (positiveLong > 0) {
                return positiveLong;
            }
        }
        long positiveLong2 = parsePositiveLong(httpURLConnection.getHeaderField(com.sigmob.sdk.downloader.core.c.e));
        if (positiveLong2 > 0) {
            return j + positiveLong2;
        }
        return -1L;
    }

    private long parsePositiveLong(String str) {
        if (str == null) {
            return -1L;
        }
        try {
            long j = Long.parseLong(str.trim());
            if (j > 0) {
                return j;
            }
            return -1L;
        } catch (NumberFormatException unused) {
            return -1L;
        }
    }

    private int calculateProgress(long j, long j2) {
        if (j2 <= 0) {
            return 0;
        }
        return (int) Math.max(0L, Math.min(100L, (j * 100) / j2));
    }

    private boolean isValidHttpUrl(String str) {
        if (str == null || str.trim().length() == 0) {
            return false;
        }
        try {
            URI uri = new URI(str.trim());
            String strValueOrEmpty = valueOrEmpty(uri.getScheme());
            if (uri.isAbsolute() && uri.getHost() != null && uri.getUserInfo() == null) {
                return "https".equalsIgnoreCase(strValueOrEmpty) || "http".equalsIgnoreCase(strValueOrEmpty);
            }
            return false;
        } catch (Exception unused) {
            return false;
        }
    }

    private String createDownloadIdentity(String str, String str2) {
        String strTrim;
        String str3;
        if (str2 == null) {
            strTrim = "";
        } else {
            try {
                strTrim = str2.trim();
            } catch (Exception unused) {
                return "";
            }
        }
        if (strTrim.length() > 0) {
            str3 = "version:" + strTrim;
        } else {
            str3 = "url:" + str.trim();
        }
        byte[] bArrDigest = MessageDigest.getInstance("SHA-256").digest(str3.getBytes("UTF-8"));
        StringBuilder sb = new StringBuilder(bArrDigest.length * 2);
        for (byte b : bArrDigest) {
            sb.append(String.format(Locale.ROOT, "%02x", Integer.valueOf(b & UByte.MAX_VALUE)));
        }
        return sb.toString();
    }

    private void setActiveConnection(HttpURLConnection httpURLConnection, int i) throws DownloadReplacedException {
        synchronized (this.downloadLock) {
            if (!this.downloadRunning || i != this.downloadGeneration) {
                httpURLConnection.disconnect();
                throw new DownloadReplacedException();
            }
            this.activeConnection = httpURLConnection;
        }
    }

    private void clearActiveConnection(HttpURLConnection httpURLConnection) {
        synchronized (this.downloadLock) {
            if (this.activeConnection == httpURLConnection) {
                this.activeConnection = null;
            }
        }
    }

    private boolean isCurrentDownload(int i) {
        boolean z;
        synchronized (this.downloadLock) {
            z = this.downloadRunning && i == this.downloadGeneration;
        }
        return z;
    }

    private void ensureCurrentDownload(int i) throws DownloadReplacedException {
        if (!isCurrentDownload(i)) {
            throw new DownloadReplacedException();
        }
    }

    private void finishCurrentDownload(int i) {
        synchronized (this.downloadLock) {
            if (i != this.downloadGeneration) {
                return;
            }
            this.downloadRunning = false;
            this.activeConnection = null;
            dismissProgressDialog();
        }
    }

    private void failCurrentDownload(int i, String str) {
        if (isCurrentDownload(i)) {
            synchronized (this.downloadLock) {
                if (i != this.downloadGeneration) {
                    return;
                }
                IDownloadResult iDownloadResult = this.resultCallback;
                this.downloadRunning = false;
                this.activeConnection = null;
                dismissProgressDialog();
                notifyResult(iDownloadResult, -1, str);
            }
        }
    }

    private void notifyCurrentResult(int i, int i2, String str) {
        synchronized (this.downloadLock) {
            if (i != this.downloadGeneration) {
                return;
            }
            notifyResult(this.resultCallback, i2, str);
        }
    }

    private void notifyResult(final IDownloadResult iDownloadResult, final int i, final String str) {
        if (iDownloadResult == null) {
            return;
        }
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda4
            @Override // java.lang.Runnable
            public final void run() {
                DxxUnityActivity.lambda$notifyResult$2(iDownloadResult, i, str);
            }
        });
    }

    static /* synthetic */ void lambda$notifyResult$2(IDownloadResult iDownloadResult, int i, String str) {
        try {
            iDownloadResult.OnResult(i, str);
        } catch (Exception unused) {
            Log.e(TAG, "Result callback failed");
        }
    }

    private void notifyProgress(final int i, final int i2) {
        synchronized (this.downloadLock) {
            if (i == this.downloadGeneration && i2 != this.lastProgress) {
                this.lastProgress = i2;
                final IDownloadProgress iDownloadProgress = this.progressCallback;
                runOnUiThread(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda5
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.m272lambda$notifyProgress$3$comunity3dplayerDxxUnityActivity(i, i2, iDownloadProgress);
                    }
                });
            }
        }
    }

    /* JADX INFO: renamed from: lambda$notifyProgress$3$com-unity3d-player-DxxUnityActivity, reason: not valid java name */
    /* synthetic */ void m272lambda$notifyProgress$3$comunity3dplayerDxxUnityActivity(int i, int i2, IDownloadProgress iDownloadProgress) {
        if (isCurrentDownload(i)) {
            ProgressDialog progressDialog = this.progressDialog;
            if (progressDialog != null && progressDialog.isShowing()) {
                this.progressDialog.setProgress(i2);
            }
            if (iDownloadProgress != null) {
                try {
                    iDownloadProgress.OnProgress(i2);
                } catch (Exception unused) {
                    Log.e(TAG, "Progress callback failed");
                }
            }
        }
    }

    private void showProgressDialog(final int i) {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.m274lambda$showProgressDialog$4$comunity3dplayerDxxUnityActivity(i);
            }
        });
    }

    /* JADX INFO: renamed from: lambda$showProgressDialog$4$com-unity3d-player-DxxUnityActivity, reason: not valid java name */
    /* synthetic */ void m274lambda$showProgressDialog$4$comunity3dplayerDxxUnityActivity(int i) {
        if (!isCurrentDownload(i) || isFinishing()) {
            return;
        }
        dismissProgressDialog();
        ProgressDialog progressDialog = new ProgressDialog(this);
        this.progressDialog = progressDialog;
        progressDialog.setTitle(getApplicationInfo().loadLabel(getPackageManager()));
        this.progressDialog.setProgressStyle(1);
        this.progressDialog.setIndeterminate(false);
        this.progressDialog.setMax(100);
        this.progressDialog.setCancelable(false);
        this.progressDialog.setCanceledOnTouchOutside(false);
        this.progressDialog.show();
    }

    private void dismissProgressDialog() {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.DxxUnityActivity$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.m271x68f54ca8();
            }
        });
    }

    /* JADX INFO: renamed from: lambda$dismissProgressDialog$5$com-unity3d-player-DxxUnityActivity, reason: not valid java name */
    /* synthetic */ void m271x68f54ca8() {
        ProgressDialog progressDialog = this.progressDialog;
        if (progressDialog != null) {
            try {
                progressDialog.dismiss();
            } catch (Exception unused) {
            }
            this.progressDialog = null;
        }
    }

    private void deleteFile(File file) {
        if (file == null || !file.exists() || file.delete()) {
            return;
        }
        Log.w(TAG, "Failed to delete obsolete APK download file");
    }

    private String toSafeFailureMessage(Exception exc) {
        if (exc instanceof HttpStatusException) {
            return "http status " + ((HttpStatusException) exc).statusCode;
        }
        return exc instanceof EOFException ? "download interrupted" : "apk download failed";
    }

    private static final class DownloadReplacedException extends Exception {
        private DownloadReplacedException() {
        }
    }

    private static final class HttpStatusException extends IOException {
        private final int statusCode;

        private HttpStatusException(int i) {
            this.statusCode = i;
        }
    }
}
