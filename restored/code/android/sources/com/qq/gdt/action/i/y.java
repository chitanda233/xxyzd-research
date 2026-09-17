package com.qq.gdt.action.i;

import java.io.ByteArrayOutputStream;
import java.util.zip.GZIPOutputStream;

/* JADX INFO: loaded from: classes3.dex */
public class y {
    /* JADX WARN: Code duplicated, block: B:40:0x0045 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public static byte[] a(byte[] bArr) throws Throwable {
        GZIPOutputStream gZIPOutputStream;
        if (bArr == null || bArr.length == 0) {
            return bArr;
        }
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        byte[] byteArray = null;
        byteArray = null;
        GZIPOutputStream gZIPOutputStream2 = null;
        try {
            try {
                try {
                    gZIPOutputStream = new GZIPOutputStream(byteArrayOutputStream);
                    try {
                        gZIPOutputStream.write(bArr);
                        gZIPOutputStream.finish();
                        byteArray = byteArrayOutputStream.toByteArray();
                        gZIPOutputStream.close();
                        byteArrayOutputStream.close();
                    } catch (Exception e) {
                        e = e;
                        o.c(e.getMessage());
                        if (gZIPOutputStream != null) {
                            gZIPOutputStream.close();
                        }
                        byteArrayOutputStream.close();
                    }
                } catch (Throwable th) {
                    th = th;
                    gZIPOutputStream2 = gZIPOutputStream;
                    if (gZIPOutputStream2 != null) {
                        try {
                            gZIPOutputStream2.close();
                        } catch (Exception e2) {
                            o.c(e2.getMessage());
                            throw th;
                        }
                    }
                    byteArrayOutputStream.close();
                    throw th;
                }
            } catch (Exception e3) {
                e = e3;
                gZIPOutputStream = null;
            } catch (Throwable th2) {
                th = th2;
                if (gZIPOutputStream2 != null) {
                    gZIPOutputStream2.close();
                }
                byteArrayOutputStream.close();
                throw th;
            }
        } catch (Exception e4) {
            o.c(e4.getMessage());
        }
        return byteArray;
    }
}
