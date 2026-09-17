package com.sigmob.sdk.videocache;

import android.content.Context;
import android.net.Uri;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.toolbox.StringUtil;
import java.io.File;
import java.io.IOException;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.SocketException;
import java.util.Iterator;
import java.util.Locale;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes4.dex */
public class HttpProxyCacheServer {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3653a = "127.0.0.1";
    private final Object b;
    private final ExecutorService c;
    private final Map<String, h> d;
    private final ServerSocket e;
    private final int f;
    private final Thread g;
    private final e h;
    private final m i;
    private InetAddress j;

    public static final class Builder {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final long f3654a = 536870912;
        private File b;
        private com.sigmob.sdk.videocache.sourcestorage.c e;
        private com.sigmob.sdk.videocache.file.a d = new com.sigmob.sdk.videocache.file.h(f3654a);
        private com.sigmob.sdk.videocache.file.c c = new com.sigmob.sdk.videocache.file.f();
        private com.sigmob.sdk.videocache.headers.b f = new com.sigmob.sdk.videocache.headers.a();

        public Builder(Context context) {
            this.e = com.sigmob.sdk.videocache.sourcestorage.d.a(context);
            this.b = v.a(context);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public e a() {
            return new e(this.b, this.c, this.d, this.e, this.f);
        }

        public HttpProxyCacheServer build() {
            return new HttpProxyCacheServer(a());
        }

        public Builder cacheDirectory(File file) {
            this.b = (File) n.a(file);
            return this;
        }

        public Builder diskUsage(com.sigmob.sdk.videocache.file.a diskUsage) {
            this.d = (com.sigmob.sdk.videocache.file.a) n.a(diskUsage);
            return this;
        }

        public Builder fileNameGenerator(com.sigmob.sdk.videocache.file.c fileNameGenerator) {
            this.c = (com.sigmob.sdk.videocache.file.c) n.a(fileNameGenerator);
            return this;
        }

        public Builder headerInjector(com.sigmob.sdk.videocache.headers.b headerInjector) {
            this.f = (com.sigmob.sdk.videocache.headers.b) n.a(headerInjector);
            return this;
        }

        public Builder maxCacheFilesCount(int count) {
            this.d = new com.sigmob.sdk.videocache.file.g(count);
            return this;
        }

        public Builder maxCacheSize(long maxSize) {
            this.d = new com.sigmob.sdk.videocache.file.h(maxSize);
            return this;
        }
    }

    private final class a implements Runnable {
        private final Socket b;

        public a(Socket socket) {
            this.b = socket;
        }

        @Override // java.lang.Runnable
        public void run() {
            HttpProxyCacheServer.this.a(this.b);
        }
    }

    private final class b implements Runnable {
        private final CountDownLatch b;

        public b(CountDownLatch startSignal) {
            this.b = startSignal;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.b.countDown();
            HttpProxyCacheServer.this.c();
        }
    }

    public HttpProxyCacheServer(Context context) {
        this(new Builder(context).a());
    }

    private HttpProxyCacheServer(e config) {
        this.b = new Object();
        this.c = ThreadPoolFactory.getFixIOExecutor();
        this.d = new ConcurrentHashMap();
        this.h = (e) n.a(config);
        try {
            this.j = InetAddress.getByName(f3653a);
            ServerSocket serverSocket = new ServerSocket(0, 8, this.j);
            this.e = serverSocket;
            int localPort = serverSocket.getLocalPort();
            this.f = localPort;
            j.a(f3653a, localPort);
            CountDownLatch countDownLatch = new CountDownLatch(1);
            SigmobLog.d("Thread create ,current thread num :" + Thread.activeCount());
            Thread thread = new Thread(new b(countDownLatch));
            this.g = thread;
            thread.start();
            countDownLatch.await();
            this.i = new m(f3653a, localPort);
        } catch (IOException | InterruptedException e) {
            this.c.shutdown();
            throw new IllegalStateException("Error starting local proxy server", e);
        }
    }

    private String a(String url) {
        return String.format(Locale.US, "http://%s:%d/%s", f3653a, Integer.valueOf(this.f), q.b(url));
    }

    private void a(File cacheFile) {
        try {
            this.h.c.a(cacheFile);
        } catch (IOException e) {
            SigmobLog.e("Error touching file " + cacheFile, e);
        }
    }

    private void a(Throwable e) {
        SigmobLog.e("HttpProxyCacheServer error", e);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(Socket socket) {
        StringBuilder sb;
        try {
            try {
                f fVarA = f.a(socket.getInputStream());
                SigmobLog.d("Request to cache proxy:" + fVarA);
                String strC = q.c(fVarA.f3660a);
                if (this.i.a(strC)) {
                    this.i.a(socket);
                } else {
                    b(strC).a(fVarA, socket);
                }
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (p e) {
                e = e;
                a(new p("Error processing request", e));
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (SocketException unused) {
                SigmobLog.d("Closing socket… Socket is closed by client.");
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (IOException e2) {
                e = e2;
                a(new p("Error processing request", e));
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            }
            SigmobLog.d(sb.append(d()).toString());
        } catch (Throwable th) {
            b(socket);
            SigmobLog.d("Opened connections: " + d());
            throw th;
        }
    }

    private boolean a() {
        return this.i.a(1, 70);
    }

    private h b(String url) throws p {
        h hVar;
        synchronized (this.b) {
            hVar = this.d.get(url);
            if (hVar == null) {
                hVar = new h(url, this.h);
                this.d.put(url, hVar);
            }
        }
        return hVar;
    }

    private void b() {
        synchronized (this.b) {
            Iterator<h> it = this.d.values().iterator();
            while (it.hasNext()) {
                it.next().a();
            }
            this.d.clear();
        }
    }

    private void b(Socket socket) {
        c(socket);
        d(socket);
        e(socket);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c() {
        while (!Thread.currentThread().isInterrupted()) {
            try {
                this.c.submit(new a(this.e.accept()));
            } catch (IOException e) {
                a(new p("Error during waiting connection", e));
                return;
            }
        }
    }

    private void c(Socket socket) {
        try {
            if (socket.isInputShutdown()) {
                return;
            }
            socket.shutdownInput();
        } catch (SocketException unused) {
            SigmobLog.d("Releasing input stream… Socket is closed by client.");
        } catch (IOException unused2) {
        }
    }

    private int d() {
        int iB;
        synchronized (this.b) {
            Iterator<h> it = this.d.values().iterator();
            iB = 0;
            while (it.hasNext()) {
                iB += it.next().b();
            }
        }
        return iB;
    }

    private void d(Socket socket) {
        try {
            if (socket.isOutputShutdown()) {
                return;
            }
            socket.shutdownOutput();
        } catch (IOException unused) {
        }
    }

    private void e(Socket socket) {
        try {
            if (socket.isClosed()) {
                return;
            }
            socket.close();
        } catch (IOException unused) {
        }
    }

    public File getCacheFile(String url) {
        return new File(this.h.f3659a, this.h.b.a(url));
    }

    public String getProxyUrl(String url) {
        return getProxyUrl(StringUtil.getUrl(url), true);
    }

    public String getProxyUrl(String url, boolean allowCachedFileUri) {
        if (!allowCachedFileUri || !isCached(url)) {
            return a() ? a(url) : url;
        }
        File cacheFile = getCacheFile(url);
        a(cacheFile);
        return Uri.fromFile(cacheFile).toString();
    }

    public boolean isCached(String url) {
        n.a(url, "Url can't be null!");
        return getCacheFile(url).exists();
    }

    public void registerCacheListener(d cacheListener, String url) {
        n.a(cacheListener, url);
        synchronized (this.b) {
            try {
                b(url).a(cacheListener);
            } catch (p e) {
                SigmobLog.w("Error registering cache listener", e);
            }
        }
    }

    public void shutdown() {
        SigmobLog.i("Shutdown proxy server");
        b();
        this.h.d.a();
        this.g.interrupt();
        try {
            if (this.e.isClosed()) {
                return;
            }
            this.e.close();
        } catch (IOException e) {
            a(new p("Error shutting down proxy server", e));
        }
    }

    public void stopCacheAndShutdown(String url) {
        synchronized (this.b) {
            h hVar = this.d.get(url);
            if (hVar != null) {
                hVar.a();
            }
        }
    }

    public void unregisterCacheListener(d cacheListener) {
        n.a(cacheListener);
        synchronized (this.b) {
            Iterator<h> it = this.d.values().iterator();
            while (it.hasNext()) {
                it.next().b(cacheListener);
            }
        }
    }

    public void unregisterCacheListener(d cacheListener, String url) {
        n.a(cacheListener, url);
        synchronized (this.b) {
            try {
                b(url).b(cacheListener);
            } catch (p e) {
                SigmobLog.w("Error registering cache listener", e);
            }
        }
    }
}
