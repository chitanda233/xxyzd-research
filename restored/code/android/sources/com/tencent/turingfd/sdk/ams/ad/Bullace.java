package com.tencent.turingfd.sdk.ams.ad;

import java.nio.ByteBuffer;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Bullace {
    public static long a(byte[] bArr) {
        long j;
        ByteBuffer byteBufferWrap = ByteBuffer.wrap(bArr);
        int length = bArr.length;
        long j2 = ((long) length) * (-4132994306676758123L);
        int i = length >> 3;
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = i2 << 3;
            long j3 = ((((long) byteBufferWrap.get(i3)) & 255) + ((((long) byteBufferWrap.get(i3 + 1)) & 255) << 8) + ((((long) byteBufferWrap.get(i3 + 2)) & 255) << 16) + ((((long) byteBufferWrap.get(i3 + 3)) & 255) << 24) + ((((long) byteBufferWrap.get(i3 + 4)) & 255) << 32) + ((((long) byteBufferWrap.get(i3 + 5)) & 255) << 40) + ((((long) byteBufferWrap.get(i3 + 6)) & 255) << 48) + ((((long) byteBufferWrap.get(i3 + 7)) & 255) << 56)) * (-4132994306676758123L);
            j2 = (j2 ^ ((j3 ^ (j3 >>> 47)) * (-4132994306676758123L))) * (-4132994306676758123L);
        }
        int i4 = length & 7;
        switch (i4) {
            case 7:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 6)) << 48;
            case 6:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 5)) << 40;
            case 5:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 4)) << 32;
            case 4:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 3)) << 24;
            case 3:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 2)) << 16;
            case 2:
                j2 ^= ((long) byteBufferWrap.get((length - i4) + 1)) << 8;
            case 1:
                long j4 = ((long) byteBufferWrap.get(length - i4)) ^ j2;
                j = -4132994306676758123L;
                j2 = j4 * (-4132994306676758123L);
                break;
            default:
                j = -4132994306676758123L;
                break;
        }
        long j5 = (j2 ^ (j2 >>> 47)) * j;
        return j5 ^ (j5 >>> 47);
    }
}
