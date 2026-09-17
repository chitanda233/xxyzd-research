package com.tencent.turingfd.sdk.ams.ad;

import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Dorado {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String[] f3846a;
    public volatile int b = 0;

    public Dorado(String[] strArr) {
        this.f3846a = strArr;
    }

    public final LeoMinor a(byte[] bArr) {
        byte[] byteArray;
        Draco draco = new Draco();
        int iA = draco.a(this.f3846a[this.b], bArr);
        if (iA != 0) {
            return new LeoMinor(iA, new byte[0]);
        }
        AtomicReference atomicReference = new AtomicReference();
        HttpURLConnection httpURLConnection = draco.f3847a;
        int i = AVMDLDataLoader.AVMDLErrorIsInvalidRequestInfo;
        if (httpURLConnection != null && draco.b) {
            try {
                InputStream inputStream = httpURLConnection.getInputStream();
                ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
                while (true) {
                    int i2 = inputStream.read();
                    if (i2 == -1) {
                        break;
                    }
                    byteArrayOutputStream.write(i2);
                }
                byteArray = byteArrayOutputStream.toByteArray();
                i = 0;
            } catch (IOException e) {
                e.printStackTrace();
                i = -4056;
                byteArray = null;
            } catch (Exception e2) {
                e2.printStackTrace();
                byteArray = null;
            }
            atomicReference.set(byteArray);
            HttpURLConnection httpURLConnection2 = draco.f3847a;
            if (httpURLConnection2 != null) {
                httpURLConnection2.disconnect();
                draco.f3847a = null;
            }
        }
        return i != 0 ? new LeoMinor(i, new byte[0]) : new LeoMinor(i, (byte[]) atomicReference.get());
    }
}
