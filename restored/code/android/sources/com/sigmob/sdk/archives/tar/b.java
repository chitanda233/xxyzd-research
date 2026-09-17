package com.sigmob.sdk.archives.tar;

import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class b extends com.sigmob.sdk.archives.c {
    private static final int b = 256;
    private static final int c = 8192;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected final d f3115a;
    private boolean d;
    private long e;
    private long f;
    private byte[] g;
    private a h;

    public b(InputStream is) {
        this(is, d.b, 512);
    }

    public b(InputStream is, int blockSize) {
        this(is, blockSize, 512);
    }

    public b(InputStream is, int blockSize, int recordSize) {
        this.f3115a = new d(is, blockSize, recordSize);
        this.g = null;
        this.d = false;
    }

    public static boolean a(byte[] signature, int length) {
        if (length < 265) {
            return false;
        }
        if (com.sigmob.sdk.archives.utils.a.a("ustar\u0000", signature, 257, 6) && com.sigmob.sdk.archives.utils.a.a(e.V, signature, 263, 2)) {
            return true;
        }
        if (com.sigmob.sdk.archives.utils.a.a(e.W, signature, 257, 6) && (com.sigmob.sdk.archives.utils.a.a(e.X, signature, 263, 2) || com.sigmob.sdk.archives.utils.a.a(e.Y, signature, 263, 2))) {
            return true;
        }
        return com.sigmob.sdk.archives.utils.a.a("ustar\u0000", signature, 257, 6) && com.sigmob.sdk.archives.utils.a.a(e.aa, signature, 263, 2);
    }

    private byte[] h() throws IOException {
        if (this.d) {
            return null;
        }
        byte[] bArrD = this.f3115a.d();
        if (bArrD == null || this.f3115a.a(bArrD)) {
            this.d = true;
        }
        if (this.d) {
            return null;
        }
        return bArrD;
    }

    private void i() throws IOException {
        int i;
        int i2;
        InputStreamReader inputStreamReader = new InputStreamReader(this, "UTF-8") { // from class: com.sigmob.sdk.archives.tar.b.1
            @Override // java.io.InputStreamReader, java.io.Reader, java.io.Closeable, java.lang.AutoCloseable
            public void close() {
            }
        };
        HashMap map = new HashMap();
        do {
            int i3 = 0;
            int i4 = 0;
            while (true) {
                try {
                    i = inputStreamReader.read();
                    if (i == -1) {
                        break;
                    }
                    i3++;
                    if (i == 32) {
                        StringBuffer stringBuffer = new StringBuffer();
                        while (true) {
                            i2 = inputStreamReader.read();
                            if (i2 == -1) {
                                break;
                            }
                            i3++;
                            if (i2 == 61) {
                                String string = stringBuffer.toString();
                                int i5 = i4 - i3;
                                char[] cArr = new char[i5];
                                int i6 = inputStreamReader.read(cArr);
                                if (i6 != i5) {
                                    throw new IOException("Failed to read Paxheader. Expected " + i5 + " chars, read " + i6);
                                }
                                map.put(string, new String(cArr, 0, i5 - 1));
                                break;
                            }
                            stringBuffer.append((char) i2);
                        }
                        i = i2;
                        break;
                    }
                    i4 = (i4 * 10) + (i - 48);
                } catch (Throwable th) {
                    inputStreamReader.close();
                    throw th;
                }
            }
        } while (i != -1);
        inputStreamReader.close();
        a();
        for (Map.Entry entry : map.entrySet()) {
            String str = (String) entry.getKey();
            String str2 = (String) entry.getValue();
            if ("path".equals(str)) {
                this.h.a(str2);
            } else if ("linkpath".equals(str)) {
                this.h.b(str2);
            } else if ("gid".equals(str)) {
                this.h.c(Integer.parseInt(str2));
            } else if ("gname".equals(str)) {
                this.h.d(str2);
            } else if ("uid".equals(str)) {
                this.h.b(Integer.parseInt(str2));
            } else if ("uname".equals(str)) {
                this.h.c(str2);
            } else if ("size".equals(str)) {
                this.h.b(Long.parseLong(str2));
            }
        }
    }

    private void j() throws IOException {
        byte[] bArrH;
        if (this.h.m()) {
            do {
                bArrH = h();
                if (this.d) {
                    this.h = null;
                    return;
                }
            } while (new c(bArrH).a());
        }
    }

    @Override // com.sigmob.sdk.archives.c
    public com.sigmob.sdk.archives.a a() throws IOException {
        return e();
    }

    protected final void a(a e) {
        this.h = e;
    }

    protected final void a(boolean b2) {
        this.d = b2;
    }

    @Override // com.sigmob.sdk.archives.c
    public boolean a(com.sigmob.sdk.archives.a ae) {
        if (ae instanceof a) {
            return !((a) ae).o();
        }
        return false;
    }

    @Override // java.io.InputStream
    public int available() {
        long j = this.e;
        long j2 = this.f;
        if (j - j2 > 2147483647L) {
            return Integer.MAX_VALUE;
        }
        return (int) (j - j2);
    }

    @Override // java.io.InputStream, java.io.Closeable, java.lang.AutoCloseable
    public void close() throws IOException {
        this.f3115a.h();
    }

    public int d() {
        return this.f3115a.b();
    }

    public a e() throws IOException {
        if (this.d) {
            return null;
        }
        if (this.h != null) {
            long j = this.e;
            long jSkip = this.f;
            while (true) {
                j -= jSkip;
                if (j <= 0) {
                    this.g = null;
                    break;
                }
                jSkip = skip(j);
                if (jSkip <= 0) {
                    throw new RuntimeException("failed to skip current tar entry");
                }
            }
        }
        byte[] bArrH = h();
        if (this.d) {
            this.h = null;
            return null;
        }
        a aVar = new a(bArrH);
        this.h = aVar;
        this.f = 0L;
        this.e = aVar.b();
        if (this.h.p()) {
            StringBuffer stringBuffer = new StringBuffer();
            byte[] bArr = new byte[256];
            while (true) {
                int i = read(bArr);
                if (i < 0) {
                    break;
                }
                stringBuffer.append(new String(bArr, 0, i));
            }
            a();
            if (this.h == null) {
                return null;
            }
            if (stringBuffer.length() > 0 && stringBuffer.charAt(stringBuffer.length() - 1) == 0) {
                stringBuffer.deleteCharAt(stringBuffer.length() - 1);
            }
            this.h.a(stringBuffer.toString());
        }
        if (this.h.q()) {
            i();
        }
        if (this.h.o()) {
            j();
        }
        return this.h;
    }

    protected final a f() {
        return this.h;
    }

    protected final boolean g() {
        return this.d;
    }

    @Override // java.io.InputStream
    public int read(byte[] buf, int offset, int numToRead) throws IOException {
        int i;
        long j = this.f;
        long j2 = this.e;
        if (j >= j2) {
            return -1;
        }
        if (((long) numToRead) + j > j2) {
            numToRead = (int) (j2 - j);
        }
        byte[] bArr = this.g;
        if (bArr != null) {
            int length = numToRead > bArr.length ? bArr.length : numToRead;
            System.arraycopy(bArr, 0, buf, offset, length);
            byte[] bArr2 = this.g;
            if (length >= bArr2.length) {
                this.g = null;
            } else {
                int length2 = bArr2.length - length;
                byte[] bArr3 = new byte[length2];
                System.arraycopy(bArr2, length, bArr3, 0, length2);
                this.g = bArr3;
            }
            i = length + 0;
            numToRead -= length;
            offset += length;
        } else {
            i = 0;
        }
        while (numToRead > 0) {
            byte[] bArrD = this.f3115a.d();
            if (bArrD == null) {
                throw new IOException("unexpected EOF with " + numToRead + " bytes unread. Occured at byte: " + c());
            }
            a(bArrD.length);
            int length3 = bArrD.length;
            if (length3 > numToRead) {
                System.arraycopy(bArrD, 0, buf, offset, numToRead);
                int i2 = length3 - numToRead;
                byte[] bArr4 = new byte[i2];
                this.g = bArr4;
                System.arraycopy(bArrD, numToRead, bArr4, 0, i2);
                length3 = numToRead;
            } else {
                System.arraycopy(bArrD, 0, buf, offset, length3);
            }
            i += length3;
            numToRead -= length3;
            offset += length3;
        }
        this.f += (long) i;
        return i;
    }

    @Override // java.io.InputStream
    public synchronized void reset() {
    }

    @Override // java.io.InputStream
    public long skip(long numToSkip) throws IOException {
        byte[] bArr = new byte[8192];
        long j = numToSkip;
        while (j > 0) {
            long j2 = 8192;
            if (j <= j2) {
                j2 = j;
            }
            int i = read(bArr, 0, (int) j2);
            if (i == -1) {
                break;
            }
            j -= (long) i;
        }
        return numToSkip - j;
    }
}
