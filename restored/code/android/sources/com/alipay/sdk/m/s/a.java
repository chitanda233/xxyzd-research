package com.alipay.sdk.m.s;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: com.alipay.sdk.m.s.a$a, reason: collision with other inner class name */
    public interface InterfaceC0050a {
        void a(File file);

        void a(Throwable th);
    }

    /* JADX WARN: Code duplicated, block: B:43:0x0059 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public static void a(String str, String str2, InterfaceC0050a interfaceC0050a) {
        try {
            HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
            httpURLConnection.connect();
            if (httpURLConnection.getResponseCode() != 200) {
                throw new IOException("Server returned HTTP " + httpURLConnection.getResponseCode());
            }
            httpURLConnection.getContentLength();
            File file = new File(str2);
            if (file.exists()) {
                file.delete();
            }
            InputStream inputStream = httpURLConnection.getInputStream();
            try {
                FileOutputStream fileOutputStream = new FileOutputStream(file);
                try {
                    byte[] bArr = new byte[4096];
                    while (true) {
                        int i = inputStream.read(bArr);
                        if (i == -1) {
                            interfaceC0050a.a(file);
                            fileOutputStream.close();
                            inputStream.close();
                            return;
                        }
                        fileOutputStream.write(bArr, 0, i);
                        if (inputStream != null) {
                            try {
                                inputStream.close();
                            } catch (Throwable th) {
                                th.addSuppressed(th);
                            }
                        }
                        throw th;
                    }
                } catch (Throwable th2) {
                    try {
                        fileOutputStream.close();
                    } catch (Throwable th3) {
                        th2.addSuppressed(th3);
                    }
                    throw th2;
                }
            } catch (Throwable th4) {
                if (inputStream != null) {
                    inputStream.close();
                }
                throw th4;
            }
        } catch (Throwable th5) {
            interfaceC0050a.a(th5);
        }
    }
}
