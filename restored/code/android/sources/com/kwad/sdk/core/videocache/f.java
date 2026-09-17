package com.kwad.sdk.core.videocache;

import android.content.Context;
import android.net.Uri;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.export.proxy.AdHttpResponseListener;
import com.kwad.sdk.utils.az;
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

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private final Object aZY;
    private final ExecutorService aZZ;
    private final Map<String, g> baa;
    private final ServerSocket bab;
    private final Thread bac;
    private final com.kwad.sdk.core.videocache.c bad;
    private final int port;

    /* synthetic */ f(com.kwad.sdk.core.videocache.c cVar, byte b2) {
        this(cVar);
    }

    private f(com.kwad.sdk.core.videocache.c cVar) {
        this.aZY = new Object();
        this.aZZ = GlobalThreadPools.Op();
        this.baa = new ConcurrentHashMap();
        this.bad = (com.kwad.sdk.core.videocache.c) az.checkNotNull(cVar);
        try {
            ServerSocket serverSocket = new ServerSocket(0, 8, InetAddress.getByName("127.0.0.1"));
            this.bab = serverSocket;
            int localPort = serverSocket.getLocalPort();
            this.port = localPort;
            i.install("127.0.0.1", localPort);
            CountDownLatch countDownLatch = new CountDownLatch(1);
            Thread thread = new Thread(new c(countDownLatch));
            this.bac = thread;
            thread.start();
            countDownLatch.await();
        } catch (IOException | InterruptedException e) {
            this.aZZ.shutdown();
            throw new IllegalStateException("Error starting local proxy server", e);
        }
    }

    public final String fv(String str) {
        return str == null ? "" : g(str, true);
    }

    private String g(String str, boolean z) {
        if (ac(str).exists()) {
            File fileAc = ac(str);
            r(fileAc);
            return Uri.fromFile(fileAc).toString();
        }
        return fz(str);
    }

    public final boolean a(String str, long j, com.kwad.sdk.core.network.a.a.C0515a c0515a, AdHttpResponseListener adHttpResponseListener) {
        com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "preloadSync preloadUrl " + str);
        if (fw(str)) {
            return true;
        }
        return com.kwad.sdk.core.network.a.a.a(fz(str), null, c0515a, j, false, adHttpResponseListener);
    }

    public final boolean fw(String str) {
        az.aB(str, "Url can't be null!");
        return ac(str).exists();
    }

    public final boolean fx(String str) {
        az.aB(str, "Url can't be null!");
        return fA(str).exists() || ac(str).exists();
    }

    public final boolean fy(String str) {
        g gVar = this.baa.get(str);
        if (gVar == null) {
            return false;
        }
        gVar.shutdown();
        this.baa.remove(str);
        return true;
    }

    private String fz(String str) {
        return String.format(Locale.US, "http://%s:%d/%s", "127.0.0.1", Integer.valueOf(this.port), l.encode(str));
    }

    private File ac(String str) {
        return new File(this.bad.aZK, this.bad.aZL.generate(str));
    }

    private File fA(String str) {
        return new File(this.bad.aZK, this.bad.aZL.generate(str) + ".download");
    }

    private void r(File file) {
        try {
            this.bad.aZM.s(file);
        } catch (IOException unused) {
            com.kwad.sdk.core.d.c.e("HttpProxyCacheServer", "Error touching file " + file);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Pf() {
        while (!Thread.currentThread().isInterrupted()) {
            try {
                Socket socketAccept = this.bab.accept();
                com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "Accept new socket " + socketAccept);
                this.aZZ.submit(new b(socketAccept));
            } catch (IOException e) {
                onError(new ProxyCacheException("Error during waiting connection", e));
                return;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r0v1, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r0v3, types: [int] */
    /* JADX WARN: Type inference failed for: r5v0, types: [com.kwad.sdk.core.videocache.f] */
    /* JADX WARN: Type inference failed for: r6v0, types: [java.net.Socket] */
    /* JADX WARN: Type inference failed for: r6v11 */
    /* JADX WARN: Type inference failed for: r6v12 */
    /* JADX WARN: Type inference failed for: r6v13 */
    /* JADX WARN: Type inference failed for: r6v3, types: [java.net.Socket] */
    /* JADX WARN: Type inference failed for: r6v7, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r6v9, types: [java.lang.String] */
    public void a(Socket socket) {
        ?? sb;
        ?? Pg = "Opened connections: ";
        try {
            try {
                d dVarB = d.b(socket.getInputStream());
                com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "Request to cache proxy:" + dVarB);
                fB(l.decode(dVarB.uri)).a(dVarB, socket);
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (ProxyCacheException e) {
                e = e;
                onError(new ProxyCacheException("Error processing request", e));
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (SocketException e2) {
                com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "Closing socket… Socket is closed by client.");
                e2.printStackTrace();
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            } catch (IOException e3) {
                e = e3;
                onError(new ProxyCacheException("Error processing request", e));
                b(socket);
                sb = new StringBuilder("Opened connections: ");
            }
            Pg = Pg();
            socket = sb.append(Pg).toString();
            com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", (String) socket);
        } catch (Throwable th) {
            b(socket);
            com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", ((String) Pg) + Pg());
            throw th;
        }
    }

    private g fB(String str) {
        g gVar;
        synchronized (this.aZY) {
            gVar = this.baa.get(str);
            if (gVar == null) {
                gVar = new g(str, this.bad);
                this.baa.put(str, gVar);
            }
        }
        return gVar;
    }

    private int Pg() {
        int iPg;
        synchronized (this.aZY) {
            Iterator<g> it = this.baa.values().iterator();
            iPg = 0;
            while (it.hasNext()) {
                iPg += it.next().Pg();
            }
        }
        return iPg;
    }

    private void b(Socket socket) {
        c(socket);
        d(socket);
        e(socket);
    }

    private void c(Socket socket) {
        try {
            if (socket.isInputShutdown()) {
                return;
            }
            socket.shutdownInput();
        } catch (SocketException unused) {
            com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "Releasing input stream… Socket is closed by client.");
        } catch (IOException e) {
            onError(new ProxyCacheException("Error closing socket input stream", e));
        }
    }

    private static void d(Socket socket) {
        try {
            if (socket.isOutputShutdown()) {
                return;
            }
            socket.shutdownOutput();
        } catch (IOException unused) {
            com.kwad.sdk.core.d.c.w("HttpProxyCacheServer", "Failed to close socket on proxy side: {}. It seems client have already closed connection.");
        }
    }

    private void e(Socket socket) {
        try {
            if (socket.isClosed()) {
                return;
            }
            socket.close();
        } catch (IOException e) {
            onError(new ProxyCacheException("Error closing socket", e));
        }
    }

    private static void onError(Throwable th) {
        com.kwad.sdk.core.d.c.printStackTraceOnly(th);
    }

    final class c implements Runnable {
        private final CountDownLatch bag;

        public c(CountDownLatch countDownLatch) {
            this.bag = countDownLatch;
        }

        @Override // java.lang.Runnable
        public final void run() {
            try {
                this.bag.countDown();
                f.this.Pf();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTrace(th);
            }
        }
    }

    final class b implements Runnable {
        private final Socket bae;

        public b(Socket socket) {
            this.bae = socket;
        }

        @Override // java.lang.Runnable
        public final void run() {
            com.kwad.sdk.core.d.c.d("HttpProxyCacheServer", "schedule SocketProcessorRunnable run");
            f.this.a(this.bae);
        }
    }

    public static final class a {
        private File aZK;
        private com.kwad.sdk.core.videocache.d.c aZN;
        private int aZP;
        private Context context;
        private int aZQ = 0;
        private com.kwad.sdk.core.videocache.a.a aZM = new com.kwad.sdk.core.videocache.a.g(536870912);
        private com.kwad.sdk.core.videocache.a.c aZL = new com.kwad.sdk.core.videocache.a.f();
        private com.kwad.sdk.core.videocache.b.b aZO = new com.kwad.sdk.core.videocache.b.a();

        public a(Context context) {
            this.context = context;
            this.aZK = o.ck(context);
        }

        public final a aL(long j) {
            this.aZM = new com.kwad.sdk.core.videocache.a.g(536870912L);
            return this;
        }

        public final a eD(int i) {
            this.aZP = i;
            return this;
        }

        public final a eE(int i) {
            this.aZQ = i;
            return this;
        }

        public final f Ph() {
            this.aZN = com.kwad.sdk.core.videocache.d.d.k(this.context, this.aZQ);
            return new f(Pi(), (byte) 0);
        }

        private com.kwad.sdk.core.videocache.c Pi() {
            return new com.kwad.sdk.core.videocache.c(this.aZK, this.aZL, this.aZM, this.aZN, this.aZO, this.aZP, this.aZQ);
        }
    }
}
