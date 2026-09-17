package com.kwad.sdk.core.videocache;

import android.text.TextUtils;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.util.Locale;

/* JADX INFO: loaded from: classes3.dex */
final class e extends k {
    private final p aZV;
    private final com.kwad.sdk.core.videocache.a.b aZW;
    private b aZX;

    public e(p pVar, com.kwad.sdk.core.videocache.a.b bVar) {
        super(pVar, bVar);
        this.aZW = bVar;
        this.aZV = pVar;
    }

    public final void a(b bVar) {
        this.aZX = bVar;
    }

    public final void a(d dVar, Socket socket) throws IOException {
        BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(socket.getOutputStream());
        bufferedOutputStream.write(b(dVar).getBytes("UTF-8"));
        long j = dVar.aZT;
        if (a(dVar)) {
            a(bufferedOutputStream, j);
        } else {
            b(bufferedOutputStream, j);
        }
    }

    private boolean a(d dVar) {
        long length = this.aZV.length();
        return (((length > 0L ? 1 : (length == 0L ? 0 : -1)) > 0) && dVar.aZU && ((float) dVar.aZT) > ((float) this.aZW.Pe()) + (((float) length) * 0.2f)) ? false : true;
    }

    private String b(d dVar) {
        String strPo = this.aZV.Po();
        boolean z = !TextUtils.isEmpty(strPo);
        long jPe = this.aZW.isCompleted() ? this.aZW.Pe() : this.aZV.length();
        boolean z2 = jPe >= 0;
        return (dVar.aZU ? "HTTP/1.1 206 PARTIAL CONTENT\n" : "HTTP/1.1 200 OK\n") + "Accept-Ranges: bytes\n" + (z2 ? format("Content-Length: %d\n", Long.valueOf(dVar.aZU ? jPe - dVar.aZT : jPe)) : "") + (z2 && dVar.aZU ? format("Content-Range: bytes %d-%d/%d\n", Long.valueOf(dVar.aZT), Long.valueOf(jPe - 1), Long.valueOf(jPe)) : "") + (z ? format("Content-Type: %s\n", strPo) : "") + "\n";
    }

    private void a(OutputStream outputStream, long j) throws IOException {
        byte[] bArr = new byte[1024];
        while (true) {
            int iA = a(bArr, j, 1024);
            if (iA == -1) {
                break;
            }
            try {
                outputStream.write(bArr, 0, iA);
                j += (long) iA;
            } catch (Exception unused) {
            }
        }
        outputStream.flush();
    }

    private void b(OutputStream outputStream, long j) {
        m jVar = this.aZV;
        if (jVar instanceof h) {
            jVar = new h((h) this.aZV);
        } else if (jVar instanceof j) {
            jVar = new j((j) this.aZV);
        }
        try {
            jVar.aM((int) j);
            byte[] bArr = new byte[1024];
            while (true) {
                int i = jVar.read(bArr);
                if (i != -1) {
                    outputStream.write(bArr, 0, i);
                } else {
                    outputStream.flush();
                    return;
                }
            }
        } finally {
            jVar.close();
        }
    }

    private static String format(String str, Object... objArr) {
        return String.format(Locale.US, str, objArr);
    }

    @Override // com.kwad.sdk.core.videocache.k
    protected final void eC(int i) {
        b bVar = this.aZX;
        if (bVar != null) {
            bVar.a(this.aZW.file, i);
        }
    }
}
