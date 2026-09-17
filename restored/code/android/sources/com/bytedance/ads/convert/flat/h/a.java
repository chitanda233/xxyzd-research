package com.bytedance.ads.convert.flat.h;

import java.io.DataInput;
import java.io.IOException;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;

/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final byte[] f1700a = {108, 116, 108, 111, 118, 101, 122, 104};

    public static short a(DataInput dataInput) throws IOException {
        byte[] bArr = new byte[2];
        dataInput.readFully(bArr);
        return ByteBuffer.wrap(bArr).order(ByteOrder.LITTLE_ENDIAN).getShort(0);
    }

    public static boolean a(byte[] bArr) {
        if (bArr.length != f1700a.length) {
            return false;
        }
        int i = 0;
        while (true) {
            byte[] bArr2 = f1700a;
            if (i >= bArr2.length) {
                return true;
            }
            if (bArr[i] != bArr2[i]) {
                return false;
            }
            i++;
        }
    }
}
