package com.sigmob.sdk.videocache;

import com.czhj.sdk.logger.SigmobLog;
import java.io.IOException;
import java.io.OutputStream;
import java.net.Proxy;
import java.net.ProxySelector;
import java.net.Socket;
import java.net.URI;
import java.net.URISyntaxException;
import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.TimeoutException;

/* JADX INFO: loaded from: classes4.dex */
class m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3673a = "ping";
    private static final String b = "ping ok";
    private final ExecutorService c = Executors.newSingleThreadExecutor();
    private final String d;
    private final int e;

    private class a implements Callable<Boolean> {
        private a() {
        }

        @Override // java.util.concurrent.Callable
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public Boolean call() throws Exception {
            return Boolean.valueOf(m.this.b());
        }
    }

    m(String host, int port) {
        this.d = (String) n.a(host);
        this.e = port;
    }

    private List<Proxy> a() {
        try {
            return ProxySelector.getDefault().select(new URI(c()));
        } catch (URISyntaxException e) {
            throw new IllegalStateException(e);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean b() throws p {
        t tVarA = s.a(c());
        try {
            byte[] bytes = b.getBytes();
            tVarA.a(0L);
            byte[] bArr = new byte[bytes.length];
            tVarA.a(bArr);
            boolean zEquals = Arrays.equals(bytes, bArr);
            SigmobLog.i("Ping response: `" + new String(bArr) + "`, pinged? " + zEquals);
            return zEquals;
        } catch (p e) {
            SigmobLog.e("Error reading ping response", e);
            return false;
        } finally {
            tVarA.b();
        }
    }

    private String c() {
        return String.format(Locale.US, "http://%s:%d/%s", this.d, Integer.valueOf(this.e), f3673a);
    }

    void a(Socket socket) throws IOException {
        OutputStream outputStream = socket.getOutputStream();
        outputStream.write("HTTP/1.1 200 OK\n\n".getBytes());
        outputStream.write(b.getBytes());
    }

    boolean a(int maxAttempts, int startTimeout) {
        int i = 0;
        while (i < maxAttempts) {
            try {
                if (((Boolean) this.c.submit(new a()).get(startTimeout, TimeUnit.MILLISECONDS)).booleanValue()) {
                    return true;
                }
                i++;
                startTimeout *= 2;
            } catch (InterruptedException e) {
                e = e;
                SigmobLog.w("Error pinging server due to unexpected error", e);
            } catch (ExecutionException e2) {
                e = e2;
                SigmobLog.w("Error pinging server due to unexpected error", e);
            } catch (TimeoutException unused) {
                SigmobLog.w("Error pinging server (attempt: " + i + ", timeout: " + startTimeout + "). ");
            }
        }
        SigmobLog.e(String.format(Locale.US, "Error pinging server (attempts: %d, max timeout: %d). Default proxies are: %s", Integer.valueOf(i), Integer.valueOf(startTimeout / 2), a()));
        return false;
    }

    boolean a(String request) {
        return f3673a.equals(request);
    }
}
