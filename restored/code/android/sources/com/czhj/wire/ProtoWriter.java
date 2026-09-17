package com.czhj.wire;

import com.alipay.sdk.m.p.a;
import com.czhj.wire.okio.BufferedSink;
import com.czhj.wire.okio.ByteString;
import java.io.IOException;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes2.dex */
public final class ProtoWriter {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final BufferedSink f2363a;

    public ProtoWriter(BufferedSink bufferedSink) {
        this.f2363a = bufferedSink;
    }

    static int a(int i) {
        return c(a(i, FieldEncoding.VARINT));
    }

    private static int a(int i, FieldEncoding fieldEncoding) {
        return (i << 3) | fieldEncoding.value;
    }

    static int a(long j) {
        if (((-128) & j) == 0) {
            return 1;
        }
        if (((-16384) & j) == 0) {
            return 2;
        }
        if (((-2097152) & j) == 0) {
            return 3;
        }
        if (((-268435456) & j) == 0) {
            return 4;
        }
        if (((-34359738368L) & j) == 0) {
            return 5;
        }
        if (((-4398046511104L) & j) == 0) {
            return 6;
        }
        if (((-562949953421312L) & j) == 0) {
            return 7;
        }
        if (((-72057594037927936L) & j) == 0) {
            return 8;
        }
        return (j & Long.MIN_VALUE) == 0 ? 9 : 10;
    }

    static int b(int i) {
        if (i >= 0) {
            return c(i);
        }
        return 10;
    }

    static long b(long j) {
        return (j >> 63) ^ (j << 1);
    }

    static int c(int i) {
        if ((i & a.g) == 0) {
            return 1;
        }
        if ((i & (-16384)) == 0) {
            return 2;
        }
        if (((-2097152) & i) == 0) {
            return 3;
        }
        return (i & (-268435456)) == 0 ? 4 : 5;
    }

    static long c(long j) {
        return (-(j & 1)) ^ (j >>> 1);
    }

    static int d(int i) {
        return (i >> 31) ^ (i << 1);
    }

    static int e(int i) {
        return (-(i & 1)) ^ (i >>> 1);
    }

    void f(int i) throws IOException {
        if (i >= 0) {
            writeVarint32(i);
        } else {
            writeVarint64(i);
        }
    }

    public void writeBytes(ByteString byteString) throws IOException {
        this.f2363a.write(byteString);
    }

    public void writeFixed32(int i) throws IOException {
        this.f2363a.writeIntLe(i);
    }

    public void writeFixed64(long j) throws IOException {
        this.f2363a.writeLongLe(j);
    }

    public void writeString(String str) throws IOException {
        this.f2363a.writeUtf8(str);
    }

    public void writeTag(int i, FieldEncoding fieldEncoding) throws IOException {
        writeVarint32(a(i, fieldEncoding));
    }

    public void writeVarint32(int i) throws IOException {
        while ((i & a.g) != 0) {
            this.f2363a.writeByte((i & WorkQueueKt.MASK) | 128);
            i >>>= 7;
        }
        this.f2363a.writeByte(i);
    }

    public void writeVarint64(long j) throws IOException {
        while (((-128) & j) != 0) {
            this.f2363a.writeByte((((int) j) & WorkQueueKt.MASK) | 128);
            j >>>= 7;
        }
        this.f2363a.writeByte((int) j);
    }
}
