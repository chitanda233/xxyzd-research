package com.kwad.framework.filedownloader.f;

import android.app.ActivityManager;
import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Environment;
import android.text.TextUtils;
import com.baidu.mobads.sdk.internal.bz;
import com.byazt.hv.TTDownloadField;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.framework.filedownloader.exception.FileDownloadGiveUpRetryException;
import com.kwad.sdk.utils.ba;
import java.io.File;
import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Locale;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    private static int aDC = 65536;
    private static long aDD = 2000;
    private static String aDE;
    private static Boolean aDF;
    private static Boolean aDG;
    private static final Pattern aDH = Pattern.compile("attachment;\\s*filename\\s*=\\s*\"([^\"]*)\"");

    public static void cU(int i) throws IllegalAccessException {
        if (aY(c.DJ())) {
            aDC = i;
            return;
        }
        throw new IllegalAccessException("This value is used in the :filedownloader process, so set this value in your process is without effect. You can add 'process.non-separate=true' in 'filedownloader.properties' to share the main process to FileDownloadService. Or you can configure this value in 'filedownloader.properties' by 'download.min-progress-step'.");
    }

    public static void af(long j) throws IllegalAccessException {
        if (aY(c.DJ())) {
            aDD = j;
            return;
        }
        throw new IllegalAccessException("This value is used in the :filedownloader process, so set this value in your process is without effect. You can add 'process.non-separate=true' in 'filedownloader.properties' to share the main process to FileDownloadService. Or you can configure this value in 'filedownloader.properties' by 'download.min-progress-time'.");
    }

    private static int DN() {
        return aDC;
    }

    private static long DO() {
        return aDD;
    }

    private static String DP() {
        if (!TextUtils.isEmpty(aDE)) {
            return aDE;
        }
        if (c.DJ().getExternalCacheDir() == null) {
            return Environment.getDownloadCacheDirectory().getAbsolutePath();
        }
        return c.DJ().getExternalCacheDir().getAbsolutePath();
    }

    public static String ci(String str) {
        return B(DP(), cj(str));
    }

    private static String cj(String str) {
        return md5(str);
    }

    private static String B(String str, String str2) {
        if (str2 == null) {
            throw new IllegalStateException("can't generate real path, the file name is null");
        }
        if (str != null) {
            return c("%s%s%s", str, File.separator, str2);
        }
        throw new IllegalStateException("can't generate real path, the directory is null");
    }

    public static String ck(String str) {
        return c("%s.temp", str);
    }

    public static int C(String str, String str2) {
        return com.kwad.framework.filedownloader.download.b.Cm().Cn().g(str, str2, false);
    }

    public static int g(String str, String str2, boolean z) {
        return com.kwad.framework.filedownloader.download.b.Cm().Cn().g(str, str2, z);
    }

    public static String md5(String str) {
        try {
            byte[] bArrDigest = MessageDigest.getInstance(bz.f456a).digest(str.getBytes("UTF-8"));
            StringBuilder sb = new StringBuilder(bArrDigest.length * 2);
            for (byte b : bArrDigest) {
                int i = b & UByte.MAX_VALUE;
                if (i < 16) {
                    sb.append("0");
                }
                sb.append(Integer.toHexString(i));
            }
            return sb.toString();
        } catch (UnsupportedEncodingException e) {
            throw new RuntimeException("Huh, UTF-8 should be supported?", e);
        } catch (NoSuchAlgorithmException e2) {
            throw new RuntimeException("Huh, MD5 should be supported?", e2);
        }
    }

    public static boolean aY(Context context) {
        boolean zEndsWith;
        Boolean bool = aDF;
        if (bool != null) {
            return bool.booleanValue();
        }
        if (e.DL().aDx) {
            zEndsWith = true;
        } else {
            if (((ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY)) == null) {
                d.d(f.class, "fail to get the activity manager!", new Object[0]);
                return false;
            }
            zEndsWith = ba.getProcessName(context).endsWith(":filedownloader");
        }
        Boolean boolValueOf = Boolean.valueOf(zEndsWith);
        aDF = boolValueOf;
        return boolValueOf.booleanValue();
    }

    public static String c(String str, Object... objArr) {
        try {
            return String.format(Locale.ENGLISH, str, objArr);
        } catch (Exception unused) {
            return str;
        }
    }

    public static void aZ(Context context) {
        File fileBa = ba(context);
        try {
            fileBa.getParentFile().mkdirs();
            fileBa.createNewFile();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static File ba(Context context) {
        return new File(context.getFilesDir().getAbsolutePath() + File.separator + "filedownloader", ".old_file_converted");
    }

    public static String cl(String str) {
        if (str == null) {
            return null;
        }
        try {
            Matcher matcher = aDH.matcher(str);
            if (matcher.find()) {
                return matcher.group(1);
            }
        } catch (IllegalStateException unused) {
        }
        return null;
    }

    public static String a(String str, boolean z, String str2) {
        if (str == null) {
            return null;
        }
        if (!z) {
            return str;
        }
        if (str2 == null) {
            return null;
        }
        return B(str, str2);
    }

    public static String cm(String str) {
        int length = str.length();
        int i = (File.separatorChar == '\\' && length > 2 && str.charAt(1) == ':') ? 2 : 0;
        int iLastIndexOf = str.lastIndexOf(File.separatorChar);
        int i2 = (iLastIndexOf != -1 || i <= 0) ? iLastIndexOf : 2;
        if (i2 == -1 || str.charAt(length - 1) == File.separatorChar) {
            return null;
        }
        if (str.indexOf(File.separatorChar) == i2 && str.charAt(i) == File.separatorChar) {
            return str.substring(0, i2 + 1);
        }
        return str.substring(0, i2);
    }

    public static String cn(String str) {
        return "FileDownloader-" + str;
    }

    public static boolean DQ() {
        ConnectivityManager connectivityManager = (ConnectivityManager) c.DJ().getSystemService("connectivity");
        if (connectivityManager == null) {
            d.d(f.class, "failed to get connectivity manager!", new Object[0]);
            return true;
        }
        NetworkInfo activeNetworkInfo = connectivityManager.getActiveNetworkInfo();
        return activeNetworkInfo == null || activeNetworkInfo.getType() != 1;
    }

    public static boolean co(String str) {
        return c.DJ().checkCallingOrSelfPermission(str) == 0;
    }

    private static long cp(String str) {
        if (str == null) {
            return -1L;
        }
        try {
            return Long.parseLong(str);
        } catch (NumberFormatException unused) {
            return -1L;
        }
    }

    public static String a(int i, com.kwad.framework.filedownloader.a.b bVar) {
        if (bVar == null) {
            throw new RuntimeException("connection is null when findEtag");
        }
        String strBU = bVar.bU(com.sigmob.sdk.downloader.core.c.g);
        if (d.aDt) {
            d.c(f.class, "etag find %s for task(%d)", strBU, Integer.valueOf(i));
        }
        return strBU;
    }

    public static long b(int i, com.kwad.framework.filedownloader.a.b bVar) {
        long jCp = cp(bVar.bU(com.sigmob.sdk.downloader.core.c.e));
        String strBU = bVar.bU(com.sigmob.sdk.downloader.core.c.h);
        if (jCp >= 0) {
            return jCp;
        }
        if (!(strBU != null && strBU.equals("chunked"))) {
            if (e.DL().aDw) {
                if (d.aDt) {
                    d.c(f.class, "%d response header is not legal but HTTP lenient is true, so handle as the case of transfer encoding chunk", Integer.valueOf(i));
                }
            } else {
                throw new FileDownloadGiveUpRetryException("can't know the size of the download file, and its Transfer-Encoding is not Chunked either.\nyou can ignore such exception by add http.lenient=true to the filedownloader.properties");
            }
        }
        return -1L;
    }

    public static String a(com.kwad.framework.filedownloader.a.b bVar, String str) {
        String strCl = cl(bVar.bU(com.sigmob.sdk.downloader.core.c.j));
        if (TextUtils.isEmpty(strCl)) {
            strCl = cj(str);
        }
        return strCl.replaceAll("\\/", "_");
    }

    public static com.kwad.framework.filedownloader.e.a cq(String str) throws IOException {
        if (TextUtils.isEmpty(str)) {
            throw new RuntimeException("found invalid internal destination path, empty");
        }
        File file = new File(str);
        if (file.exists() && file.isDirectory()) {
            file.delete();
            if (!file.createNewFile()) {
                throw new RuntimeException(c("found invalid internal destination path[%s], & path is directory[%B]", str, Boolean.valueOf(file.isDirectory())));
            }
        }
        if (!file.exists() && !file.createNewFile()) {
            throw new IOException(c("create new file error  %s", file.getAbsolutePath()));
        }
        return com.kwad.framework.filedownloader.download.b.Cm().b(file);
    }

    public static boolean b(int i, com.kwad.framework.filedownloader.d.c cVar) {
        return a(i, cVar, (Boolean) null);
    }

    private static boolean a(int i, com.kwad.framework.filedownloader.d.c cVar, Boolean bool) {
        if (cVar == null) {
            if (d.aDt) {
                d.c(f.class, "can't continue %d model == null", Integer.valueOf(i));
            }
            return false;
        }
        if (cVar.CB() == null) {
            if (d.aDt) {
                d.c(f.class, "can't continue %d temp path == null", Integer.valueOf(i));
            }
            return false;
        }
        return a(i, cVar, cVar.CB(), null);
    }

    public static boolean a(int i, com.kwad.framework.filedownloader.d.c cVar, String str, Boolean bool) {
        if (str == null) {
            if (d.aDt) {
                d.c(f.class, "can't continue %d path = null", Integer.valueOf(i));
            }
        } else {
            File file = new File(str);
            boolean zExists = file.exists();
            boolean zIsDirectory = file.isDirectory();
            if (!zExists || zIsDirectory) {
                if (d.aDt) {
                    d.c(f.class, "can't continue %d file not suit, exists[%B], directory[%B]", Integer.valueOf(i), Boolean.valueOf(zExists), Boolean.valueOf(zIsDirectory));
                }
            } else {
                long length = file.length();
                long jDj = cVar.Dj();
                if (cVar.Dm() <= 1 && jDj == 0) {
                    if (d.aDt) {
                        d.c(f.class, "can't continue %d the downloaded-record is zero.", Integer.valueOf(i));
                    }
                } else {
                    long total = cVar.getTotal();
                    if (length < jDj || (total != -1 && (length > total || jDj >= total))) {
                        if (d.aDt) {
                            d.c(f.class, "can't continue %d dirty data fileLength[%d] sofar[%d] total[%d]", Integer.valueOf(i), Long.valueOf(length), Long.valueOf(jDj), Long.valueOf(total));
                        }
                    } else {
                        if (bool == null || bool.booleanValue() || total != length) {
                            return true;
                        }
                        if (d.aDt) {
                            d.c(f.class, "can't continue %d, because of the output stream doesn't support seek, but the task has already pre-allocated, so we only can download it from the very beginning.", Integer.valueOf(i));
                        }
                    }
                }
            }
        }
        return false;
    }

    public static void D(String str, String str2) {
        cr(str2);
        cs(str);
    }

    private static void cr(String str) {
        if (str != null) {
            File file = new File(str);
            if (file.exists()) {
                file.delete();
            }
        }
    }

    public static void cs(String str) {
        if (str != null) {
            File file = new File(str);
            if (file.exists()) {
                file.delete();
            }
        }
    }

    public static boolean i(long j, long j2) {
        return j > ((long) DN()) && j2 > DO();
    }

    public static String DR() {
        return c("FileDownloader/%s", BuildConfig.VERSION_NAME);
    }
}
