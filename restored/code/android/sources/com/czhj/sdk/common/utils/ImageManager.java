package com.czhj.sdk.common.utils;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Environment;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.util.LruCache;
import android.widget.ImageView;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import java.io.File;
import java.io.FileOutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Objects;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes2.dex */
public class ImageManager {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile ImageManager f2285a;
    private final Context b;
    private final ExecutorService c = ThreadPoolFactory.getFixIOExecutor();
    private final LruCache<String, Bitmap> d = new LruCache<>(4194304);
    private final Handler e = new Handler(Looper.getMainLooper());
    private File f;

    public interface BitmapLoadedListener {
        void onBitmapLoadFailed();

        void onBitmapLoaded(Bitmap bitmap);
    }

    public class RequestCreatorRunnable implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        String f2289a;
        int b;
        int c;
        ImageView d;

        public RequestCreatorRunnable(String str) {
            this.f2289a = StringUtil.getUrl(str);
        }

        private Bitmap a() {
            File file = new File(ImageManager.this.a(), Md5Util.getMd5FilenameFromUrl(this.f2289a));
            if (!file.exists() || file.length() <= 0) {
                return null;
            }
            return BitmapFactory.decodeFile(file.getAbsolutePath());
        }

        private void b() {
            ImageManager.this.e.post(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager.RequestCreatorRunnable.2
                @Override // java.lang.Runnable
                public void run() {
                    if (RequestCreatorRunnable.this.c == 0 || RequestCreatorRunnable.this.d == null) {
                        return;
                    }
                    RequestCreatorRunnable.this.d.setImageResource(RequestCreatorRunnable.this.c);
                }
            });
        }

        public RequestCreatorRunnable error(int i) {
            this.c = i;
            return this;
        }

        public void into(ImageView imageView) {
            this.d = imageView;
            int i = this.b;
            if (i != 0 && imageView != null) {
                imageView.setImageResource(i);
            }
            if (TextUtils.isEmpty(this.f2289a)) {
                return;
            }
            Bitmap bitmap = (Bitmap) ImageManager.this.d.get(this.f2289a);
            if (bitmap != null && imageView != null) {
                imageView.setImageBitmap(bitmap);
                return;
            }
            Bitmap bitmapA = a();
            if (bitmapA == null || imageView == null) {
                ImageManager.this.c.submit(this);
            } else {
                imageView.setImageBitmap(bitmapA);
                ImageManager.this.d.put(this.f2289a, bitmapA);
            }
        }

        public RequestCreatorRunnable placeholder(int i) {
            this.b = i;
            return this;
        }

        @Override // java.lang.Runnable
        public void run() {
            int i = 0;
            while (true) {
                int i2 = i + 1;
                if (i >= 3) {
                    return;
                }
                try {
                    HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(this.f2289a).openConnection();
                    httpURLConnection.setRequestMethod("GET");
                    httpURLConnection.setConnectTimeout(2000);
                    if (httpURLConnection.getResponseCode() == 200) {
                        final Bitmap bitmapDecodeStream = BitmapFactory.decodeStream(httpURLConnection.getInputStream());
                        ImageManager.this.e.post(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager.RequestCreatorRunnable.1
                            @Override // java.lang.Runnable
                            public void run() {
                                if (RequestCreatorRunnable.this.d == null) {
                                    return;
                                }
                                RequestCreatorRunnable.this.d.setImageBitmap(bitmapDecodeStream);
                                RequestCreatorRunnable.this.d = null;
                            }
                        });
                        ImageManager.this.d.put(this.f2289a, bitmapDecodeStream);
                        bitmapDecodeStream.compress(Bitmap.CompressFormat.PNG, 100, new FileOutputStream(new File(ImageManager.this.a(), Md5Util.getMd5FilenameFromUrl(this.f2289a))));
                        return;
                    }
                    b();
                } catch (Exception e) {
                    e.printStackTrace();
                    b();
                }
                i = i2;
            }
        }
    }

    public ImageManager(Context context) {
        this.b = context.getApplicationContext();
    }

    private static ImageManager a(Context context) {
        if (f2285a == null) {
            synchronized (ImageManager.class) {
                if (f2285a == null) {
                    f2285a = new ImageManager(context);
                }
            }
        }
        return f2285a;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public File a() {
        File file = this.f;
        if (file != null && file.isDirectory() && this.f.exists()) {
            return this.f;
        }
        File file2 = Environment.getExternalStorageState().equals("mounted") ? new File(this.b.getExternalCacheDir(), "SigImageCache") : new File(this.b.getCacheDir(), "SigImageCache");
        if (!file2.exists()) {
            file2.mkdirs();
        }
        this.f = file2;
        return file2;
    }

    public static ImageManager with(Context context) {
        return a(context);
    }

    public void clearCache() {
        ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    File[] fileArrClearCacheFileByCount = FileUtil.clearCacheFileByCount(FileUtil.orderByDate(ImageManager.this.a().getAbsolutePath()), 100);
                    SigmobLog.i(fileArrClearCacheFileByCount == null ? "native ad file list is null" : "native ad file remain num: " + fileArrClearCacheFileByCount.length);
                } catch (Throwable th) {
                    SigmobLog.e("clean native ad file error", th);
                }
            }
        });
    }

    public ImageManager customCachePath(File file) {
        this.f = file;
        return this;
    }

    public void getBitmap(String str, final BitmapLoadedListener bitmapLoadedListener) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        final String url = StringUtil.getUrl(str);
        Bitmap bitmapDecodeFile = this.d.get(url);
        if (bitmapDecodeFile == null) {
            bitmapDecodeFile = null;
        } else {
            if (!bitmapDecodeFile.isRecycled()) {
                bitmapLoadedListener.onBitmapLoaded(bitmapDecodeFile);
                return;
            }
            this.d.remove(url);
        }
        File file = new File(a(), Md5Util.getMd5FilenameFromUrl(url));
        if (file.exists() && file.length() > 0) {
            bitmapDecodeFile = BitmapFactory.decodeFile(file.getAbsolutePath());
        }
        if (bitmapDecodeFile == null) {
            this.c.submit(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager.2
                @Override // java.lang.Runnable
                public void run() {
                    try {
                        HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(url).openConnection();
                        httpURLConnection.setRequestMethod("GET");
                        httpURLConnection.setConnectTimeout(2000);
                        if (httpURLConnection.getResponseCode() == 200) {
                            final Bitmap bitmapDecodeStream = BitmapFactory.decodeStream(httpURLConnection.getInputStream());
                            httpURLConnection.disconnect();
                            ImageManager.this.e.post(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager.2.1
                                @Override // java.lang.Runnable
                                public void run() {
                                    bitmapLoadedListener.onBitmapLoaded(bitmapDecodeStream);
                                }
                            });
                            ImageManager.this.d.put(url, bitmapDecodeStream);
                            bitmapDecodeStream.compress(Bitmap.CompressFormat.PNG, 100, new FileOutputStream(new File(ImageManager.this.a(), Md5Util.getMd5FilenameFromUrl(url))));
                        }
                    } catch (Exception unused) {
                        Handler handler = ImageManager.this.e;
                        final BitmapLoadedListener bitmapLoadedListener2 = bitmapLoadedListener;
                        Objects.requireNonNull(bitmapLoadedListener2);
                        handler.post(new Runnable() { // from class: com.czhj.sdk.common.utils.ImageManager$2$$ExternalSyntheticLambda0
                            @Override // java.lang.Runnable
                            public final void run() {
                                bitmapLoadedListener2.onBitmapLoadFailed();
                            }
                        });
                    }
                }
            });
        } else {
            this.d.put(url, bitmapDecodeFile);
            bitmapLoadedListener.onBitmapLoaded(bitmapDecodeFile);
        }
    }

    public RequestCreatorRunnable load(String str) {
        return new RequestCreatorRunnable(str);
    }
}
