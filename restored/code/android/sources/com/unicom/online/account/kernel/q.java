package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import java.io.IOException;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.security.SecureRandom;
import java.security.cert.X509Certificate;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLContext;
import javax.net.ssl.SSLPeerUnverifiedException;
import javax.net.ssl.SSLSession;
import javax.net.ssl.SSLSocket;
import javax.net.ssl.SSLSocketFactory;
import javax.net.ssl.TrustManager;

/* JADX INFO: loaded from: classes4.dex */
public final class q {
    public static final String[] f = {"TLSv1.1", "TLSv1.2"};
    public ExecutorService b = Executors.newCachedThreadPool();
    public final ConcurrentHashMap c = new ConcurrentHashMap();
    public final ConcurrentHashMap d = new ConcurrentHashMap();
    public final ConcurrentHashMap e = new ConcurrentHashMap();

    public final void b(Context context, Network network, ArrayList arrayList) {
        o oVar;
        if (arrayList.isEmpty()) {
            return;
        }
        arrayList.size();
        Iterator it = arrayList.iterator();
        while (it.hasNext()) {
            t tVar = (t) it.next();
            if (tVar != null && !TextUtils.isEmpty(tVar.b)) {
                String str = tVar.b;
                String str2 = tVar.c;
                int i = TextUtils.isEmpty(str2) ? 443 : Integer.parseInt(str2);
                int i2 = (i <= 0 || i > 65535) ? 443 : i;
                String str3 = str + ":" + i2;
                o oVar2 = (o) this.d.get(str + ":" + i2);
                if (oVar2 == null) {
                    oVar2 = o.NONE;
                }
                if (oVar2 != o.CONNECTED && oVar2 != (oVar = o.CONNECTING)) {
                    this.d.put(str3, oVar);
                    this.e.put(str3, new CountDownLatch(1));
                    ExecutorService executorService = this.b;
                    if (executorService == null || executorService.isShutdown() || this.b.isTerminated()) {
                        this.b = Executors.newCachedThreadPool();
                    }
                    this.b.execute(new m(this, context, str, i2, network, str3));
                }
            }
        }
    }

    public final p c(String str, int i, Network network) {
        CountDownLatch countDownLatch;
        String str2 = str + ":" + i;
        p pVarB = (p) this.c.get(str2);
        if (pVarB != null && pVarB.b.isConnected() && !pVarB.b.isClosed()) {
            return pVarB;
        }
        o oVar = (o) this.d.get(str + ":" + i);
        if (oVar == null) {
            oVar = o.NONE;
        }
        if (oVar == o.CONNECTING && (countDownLatch = (CountDownLatch) this.e.get(str2)) != null) {
            try {
                countDownLatch.await(ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, TimeUnit.MILLISECONDS);
            } catch (InterruptedException unused) {
            }
            pVarB = (p) this.c.get(str2);
            if (pVarB != null && pVarB.b.isConnected() && !pVarB.b.isClosed()) {
                return pVarB;
            }
            o oVar2 = (o) this.d.get(str + ":" + i);
            if (oVar2 == null) {
                oVar2 = o.NONE;
            }
            if (oVar2 == o.FAILED) {
                return null;
            }
        }
        try {
            pVarB = b(str, i, network);
            if (pVarB != null) {
                this.c.put(str2, pVarB);
                this.d.put(str2, o.CONNECTED);
            } else {
                this.d.put(str2, o.FAILED);
                ao.v = "域名 " + str + " 端口 " + i + "创建新连接失败";
            }
        } catch (Exception e) {
            this.d.put(str2, o.FAILED);
            ao.v = "域名 " + str + " 端口 " + i + " 创建新连接异常: " + e.getMessage();
            e.getMessage();
            as.b(e);
        }
        return pVarB;
    }

    public static p b(String str, int i, Network network) throws Exception {
        Socket socket;
        bi biVarB = bi.b();
        boolean zVerify = true;
        TrustManager[] trustManagerArr = {new n(str)};
        SSLContext sSLContext = SSLContext.getInstance("TLS");
        sSLContext.init(null, trustManagerArr, new SecureRandom());
        SSLSocketFactory socketFactory = sSLContext.getSocketFactory();
        if (network != null) {
            socket = network.getSocketFactory().createSocket();
        } else {
            socket = new Socket();
        }
        try {
            socket.setTcpNoDelay(true);
            socket.setKeepAlive(true);
        } catch (Exception e) {
            e.getMessage();
        }
        socket.connect(new InetSocketAddress(str, i), biVarB.b + biVarB.c);
        SSLSocket sSLSocket = (SSLSocket) socketFactory.createSocket(socket, str, i, true);
        sSLSocket.setEnabledProtocols(f);
        sSLSocket.setSoTimeout(biVarB.d);
        try {
            sSLSocket.startHandshake();
            sSLSocket.setSoTimeout(biVarB.e);
            SSLSession session = sSLSocket.getSession();
            if (TextUtils.isEmpty(str) || session == null) {
                zVerify = false;
            } else {
                try {
                    if (!ao.b(str, ((X509Certificate) session.getPeerCertificates()[0]).getSubjectDN().getName())) {
                        zVerify = HttpsURLConnection.getDefaultHostnameVerifier().verify(str, session);
                    }
                } catch (SSLPeerUnverifiedException e2) {
                    as.b(e2);
                    zVerify = false;
                } catch (Exception e3) {
                    as.b(e3);
                    zVerify = false;
                }
            }
            if (!zVerify) {
                ao.v = "主机名验证失败: " + str;
                try {
                    sSLSocket.close();
                } catch (Exception unused) {
                }
                return null;
            }
            return new p(sSLSocket);
        } catch (Exception e4) {
            as.b(e4);
            ao.v = "createSSLSocket: " + e4.getMessage();
            try {
                sSLSocket.close();
            } catch (Exception unused2) {
            }
            throw e4;
        }
    }

    public final void c() {
        b();
        ExecutorService executorService = this.b;
        if (executorService == null || executorService.isShutdown()) {
            return;
        }
        this.b.shutdown();
        try {
            if (this.b.awaitTermination(1L, TimeUnit.SECONDS)) {
                return;
            }
            this.b.shutdownNow();
        } catch (InterruptedException unused) {
            this.b.shutdownNow();
            Thread.currentThread().interrupt();
        }
    }

    public final void b() {
        for (Map.Entry entry : this.c.entrySet()) {
            p pVar = (p) entry.getValue();
            if (pVar != null) {
                try {
                    if (!pVar.b.isClosed()) {
                        pVar.b.close();
                    }
                } catch (IOException e) {
                    String[] strArrSplit = ((String) entry.getKey()).split(":");
                    String str = strArrSplit[0];
                    if (strArrSplit.length > 1) {
                        String str2 = strArrSplit[1];
                    }
                    e.getMessage();
                }
            }
        }
        this.c.clear();
        this.d.clear();
        this.e.clear();
    }
}
