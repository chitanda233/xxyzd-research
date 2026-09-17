package com.tencent.turingfd.sdk.ams.ad;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.zip.DeflaterOutputStream;
import java.util.zip.InflaterInputStream;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.private, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cprivate {
    public static byte[] a(byte[] bArr) {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        DeflaterOutputStream deflaterOutputStream = new DeflaterOutputStream(byteArrayOutputStream);
        try {
            try {
                deflaterOutputStream.write(bArr);
                deflaterOutputStream.finish();
                byte[] byteArray = byteArrayOutputStream.toByteArray();
                try {
                    byteArrayOutputStream.close();
                    deflaterOutputStream.close();
                    return byteArray;
                } catch (IOException e) {
                    e.printStackTrace();
                    return byteArray;
                }
            } catch (IOException e2) {
                e2.printStackTrace();
                return null;
            }
        } catch (Exception unused) {
            byteArrayOutputStream.close();
            deflaterOutputStream.close();
            return null;
        } catch (Throwable th) {
            try {
                byteArrayOutputStream.close();
                deflaterOutputStream.close();
            } catch (IOException e3) {
                e3.printStackTrace();
            }
            throw th;
        }
    }

    public static byte[] b(byte[] bArr) {
        ByteArrayInputStream byteArrayInputStream = new ByteArrayInputStream(bArr);
        InflaterInputStream inflaterInputStream = new InflaterInputStream(byteArrayInputStream);
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        while (true) {
            try {
                try {
                    int i = inflaterInputStream.read();
                    if (i == -1) {
                        byte[] byteArray = byteArrayOutputStream.toByteArray();
                        try {
                            byteArrayInputStream.close();
                            inflaterInputStream.close();
                            byteArrayOutputStream.close();
                            return byteArray;
                        } catch (IOException e) {
                            e.printStackTrace();
                            return byteArray;
                        }
                    }
                    byteArrayOutputStream.write(i);
                } catch (IOException e2) {
                    e2.printStackTrace();
                    return null;
                }
            } catch (Exception unused) {
                byteArrayInputStream.close();
                inflaterInputStream.close();
                byteArrayOutputStream.close();
                return null;
            } catch (Throwable th) {
                try {
                    byteArrayInputStream.close();
                    inflaterInputStream.close();
                    byteArrayOutputStream.close();
                } catch (IOException e3) {
                    e3.printStackTrace();
                }
                throw th;
            }
            e2.printStackTrace();
            return null;
        }
    }
}
