package com.byazt.po;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.io.RandomAccessFile;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1403, 54})
public class ve {
    public final byte[] c = new byte[2];
    public final byte[] tt = new byte[4];

    public int c(RandomAccessFile randomAccessFile) throws IOException {
        randomAccessFile.readFully(this.tt);
        return tt(this.tt);
    }

    public int tt(RandomAccessFile randomAccessFile) throws IOException {
        randomAccessFile.readFully(this.c);
        return c(this.c);
    }

    public void c(RandomAccessFile randomAccessFile, int i) throws IOException {
        c(this.c, i);
        randomAccessFile.write(this.c);
    }

    public void c(ByteArrayOutputStream byteArrayOutputStream, int i) throws IOException {
        c(this.c, i);
        byteArrayOutputStream.write(this.c);
    }

    public void c(OutputStream outputStream, int i) throws IOException {
        tt(this.tt, i);
        outputStream.write(this.tt);
    }

    private int c(byte[] bArr) {
        return ((bArr[1] & UByte.MAX_VALUE) << 8) | (bArr[0] & UByte.MAX_VALUE);
    }

    private int tt(byte[] bArr) {
        return ((((bArr[3] & UByte.MAX_VALUE) << 8) | (bArr[2] & UByte.MAX_VALUE)) << 16) | (bArr[0] & UByte.MAX_VALUE) | ((bArr[1] & UByte.MAX_VALUE) << 8);
    }

    private void c(byte[] bArr, int i) {
        bArr[1] = (byte) (i >>> 8);
        bArr[0] = (byte) (i & 255);
    }

    private void tt(byte[] bArr, int i) {
        bArr[3] = (byte) (i >>> 24);
        bArr[2] = (byte) (i >>> 16);
        bArr[1] = (byte) (i >>> 8);
        bArr[0] = (byte) (i & 255);
    }
}
