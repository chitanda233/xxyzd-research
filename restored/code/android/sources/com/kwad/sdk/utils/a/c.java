package com.kwad.sdk.utils.a;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.C;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.ByteOrder;
import java.nio.MappedByteBuffer;
import java.nio.channels.FileChannel;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.Executor;
import kotlin.UByte;
import kotlin.UShort;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static final int PAGE_SIZE;
    private static final int[] brM = {0, 1, 4, 4, 8, 8};
    private static final byte[] brN = new byte[0];
    private static final int brO;
    private static final int brP;
    private static final int brQ;
    private final String app;
    private final Map<String, b> brR;
    private FileChannel brT;
    private FileChannel brU;
    private RandomAccessFile brV;
    private RandomAccessFile brW;
    private MappedByteBuffer brX;
    private MappedByteBuffer brY;
    private com.kwad.sdk.utils.a.b brZ;
    private int bsa;
    private long bsb;
    private int bse;
    private int bsf;
    private int bsg;
    private boolean bsh;
    private String bsi;
    private int bsj;
    private int bsl;
    private final String name;
    private final d brS = com.kwad.sdk.utils.a.d.bsw;
    private final Map<String, com.kwad.sdk.utils.a.a.b> bsc = new HashMap();
    private boolean bsd = false;
    private final ArrayList<e> bsk = new ArrayList<>();
    private boolean bsm = true;
    private final Executor bsn = new f();

    public interface b<T> {
        String XM();

        T f(byte[] bArr, int i, int i2);

        byte[] u(T t);
    }

    public interface d {
        void a(String str, Exception exc);

        void e(String str, Throwable th);

        void i(String str, String str2);
    }

    private static long g(long j, int i) {
        int i2 = (i & 7) << 3;
        return (j >>> (64 - i2)) | (j << i2);
    }

    static {
        int iXO = h.XO();
        PAGE_SIZE = iXO;
        brO = iXO - 192;
        int iMax = Math.max(iXO << 1, 16384);
        brP = iMax;
        brQ = iMax << 1;
    }

    c(String str, String str2, b[] bVarArr, int i) {
        this.app = str;
        this.name = str2;
        this.bsl = i;
        HashMap map = new HashMap();
        g gVar = g.bsD;
        map.put(gVar.XM(), gVar);
        if (bVarArr != null && bVarArr.length > 0) {
            for (b bVar : bVarArr) {
                String strXM = bVar.XM();
                if (map.containsKey(strXM)) {
                    ix("duplicate encoder tag:" + strXM);
                } else {
                    map.put(strXM, bVar);
                }
            }
        }
        this.brR = map;
        synchronized (this.bsc) {
            com.kwad.sdk.utils.a.d.getExecutor().execute(new Runnable() { // from class: com.kwad.sdk.utils.a.c.1
                @Override // java.lang.Runnable
                public final void run() {
                    c.this.Xt();
                }
            });
            while (!this.bsd) {
                try {
                    this.bsc.wait();
                } catch (InterruptedException unused) {
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void Xt() {
        synchronized (this.bsc) {
            this.bsd = true;
            this.bsc.notify();
        }
        long jNanoTime = System.nanoTime();
        if (!Xw() && this.bsl == 0) {
            Xu();
        }
        if (this.brZ == null) {
            this.brZ = new com.kwad.sdk.utils.a.b(PAGE_SIZE);
        }
        if (this.brS != null) {
            info("loading finish, data len:" + this.bsa + ", get keys:" + this.bsc.size() + ", use time:" + ((System.nanoTime() - jNanoTime) / C.MICROS_PER_SECOND) + " ms");
        }
    }

    /* JADX WARN: Code duplicated, block: B:31:0x0116  */
    /* JADX WARN: Code duplicated, block: B:49:0x01a1  */
    private void Xu() {
        boolean z;
        boolean z2;
        File file = new File(this.app, this.name + ".kva");
        File file2 = new File(this.app, this.name + ".kvb");
        try {
            if (h.ag(file) && h.ag(file2)) {
                this.brV = new RandomAccessFile(file, "rw");
                this.brW = new RandomAccessFile(file2, "rw");
                long length = this.brV.length();
                long length2 = this.brW.length();
                this.brT = this.brV.getChannel();
                this.brU = this.brW.getChannel();
                try {
                    MappedByteBuffer map = this.brT.map(FileChannel.MapMode.READ_WRITE, 0L, length > 0 ? length : PAGE_SIZE);
                    this.brX = map;
                    map.order(ByteOrder.LITTLE_ENDIAN);
                    MappedByteBuffer map2 = this.brU.map(FileChannel.MapMode.READ_WRITE, 0L, length2 > 0 ? length2 : PAGE_SIZE);
                    this.brY = map2;
                    map2.order(ByteOrder.LITTLE_ENDIAN);
                    this.brZ = new com.kwad.sdk.utils.a.b(this.brX.capacity());
                    if (length == 0 && length2 == 0) {
                        this.bsa = 12;
                        return;
                    }
                    int i = this.brX.getInt();
                    long j = this.brX.getLong();
                    int i2 = this.brY.getInt();
                    long j2 = this.brY.getLong();
                    if (i < 0 || i > length - 12) {
                        z = false;
                    } else {
                        this.bsa = i + 12;
                        this.brX.rewind();
                        this.brX.get(this.brZ.brL, 0, this.bsa);
                        if (j == this.brZ.L(12, i) && Xx() == 0) {
                            this.bsb = j;
                            z = true;
                        } else {
                            z = false;
                        }
                    }
                    if (z) {
                        if (length == length2 && Xv()) {
                            return;
                        }
                        g(new Exception("B file error"));
                        a(this.brX, this.brY, this.bsa);
                        return;
                    }
                    if (i2 < 0 || i2 > length2 - 12) {
                        z2 = false;
                    } else {
                        this.bsc.clear();
                        XK();
                        this.bsa = i2 + 12;
                        if (this.brZ.brL.length != this.brY.capacity()) {
                            this.brZ = new com.kwad.sdk.utils.a.b(this.brY.capacity());
                        }
                        this.brY.rewind();
                        this.brY.get(this.brZ.brL, 0, this.bsa);
                        if (j2 == this.brZ.L(12, i2) && Xx() == 0) {
                            g(new Exception("A file error"));
                            a(this.brY, this.brX, this.bsa);
                            this.bsb = j2;
                            z2 = true;
                        } else {
                            z2 = false;
                        }
                    }
                    if (z2) {
                        return;
                    }
                    ix("both files error");
                    XD();
                    return;
                } catch (IOException e2) {
                    z(e2);
                    XC();
                    j(file, file2);
                    return;
                }
            }
            z(new Exception("open file failed"));
            XC();
        } catch (Throwable th) {
            z(th);
            XE();
            XC();
        }
    }

    private void j(File file, File file2) {
        try {
            if (af(file)) {
                return;
            }
        } catch (IOException e2) {
            g(e2);
        }
        XE();
        try {
            if (af(file2)) {
                return;
            }
        } catch (Exception e3) {
            g(e3);
        }
        XE();
    }

    private boolean Xv() {
        com.kwad.sdk.utils.a.b bVar = new com.kwad.sdk.utils.a.b(this.bsa);
        MappedByteBuffer mappedByteBuffer = this.brY;
        if (mappedByteBuffer != null) {
            mappedByteBuffer.rewind();
            this.brY.get(bVar.brL, 0, this.bsa);
        }
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 == null) {
            return true;
        }
        byte[] bArr = bVar2.brL;
        byte[] bArr2 = bVar.brL;
        for (int i = 0; i < this.bsa; i++) {
            if (bArr[i] != bArr2[i]) {
                return false;
            }
        }
        return true;
    }

    private boolean Xw() {
        File file = new File(this.app, this.name + ".kvc");
        File file2 = new File(this.app, this.name + ".tmp");
        boolean z = false;
        try {
            if (!file.exists()) {
                file = file2.exists() ? file2 : null;
            }
            if (file != null) {
                if (af(file)) {
                    if (this.bsl != 0) {
                        return false;
                    }
                    if (a(this.brZ)) {
                        info("recover from c file");
                        try {
                            XB();
                            return true;
                        } catch (Exception e2) {
                            e = e2;
                            z = true;
                            z(e);
                            return z;
                        }
                    }
                    this.bsl = 1;
                    return false;
                }
                XE();
                XB();
                return false;
            }
            if (this.bsl == 0) {
                return false;
            }
            File file3 = new File(this.app, this.name + ".kva");
            File file4 = new File(this.app, this.name + ".kvb");
            if (!file3.exists() || !file4.exists()) {
                return false;
            }
            j(file3, file4);
            return false;
        } catch (Exception e3) {
            e = e3;
        }
    }

    private boolean af(File file) {
        com.kwad.sdk.utils.a.b bVar;
        long length = file.length();
        if (length != 0 && length <= 536870912) {
            int i = (int) length;
            int iM = M(PAGE_SIZE, i);
            com.kwad.sdk.utils.a.b bVar2 = this.brZ;
            if (bVar2 != null && bVar2.brL.length == iM) {
                bVar = this.brZ;
                bVar.position = 0;
            } else {
                com.kwad.sdk.utils.a.b bVar3 = new com.kwad.sdk.utils.a.b(new byte[iM]);
                this.brZ = bVar3;
                bVar = bVar3;
            }
            h.a(file, bVar.brL, i);
            int i2 = bVar.getInt();
            long j = bVar.getLong();
            this.bsa = i2 + 12;
            if (i2 >= 0 && i2 <= i - 12 && j == bVar.L(12, i2) && Xx() == 0) {
                this.bsb = j;
                return true;
            }
        }
        return false;
    }

    private boolean a(com.kwad.sdk.utils.a.b bVar) {
        int length = bVar.brL.length;
        File file = new File(this.app, this.name + ".kva");
        File file2 = new File(this.app, this.name + ".kvb");
        try {
            if (!h.ag(file) || !h.ag(file2)) {
                throw new Exception("open file failed");
            }
            RandomAccessFile randomAccessFile = new RandomAccessFile(file, "rw");
            RandomAccessFile randomAccessFile2 = new RandomAccessFile(file2, "rw");
            long j = length;
            randomAccessFile.setLength(j);
            randomAccessFile2.setLength(j);
            this.brT = randomAccessFile.getChannel();
            this.brU = randomAccessFile2.getChannel();
            MappedByteBuffer map = this.brT.map(FileChannel.MapMode.READ_WRITE, 0L, j);
            this.brX = map;
            map.order(ByteOrder.LITTLE_ENDIAN);
            MappedByteBuffer map2 = this.brU.map(FileChannel.MapMode.READ_WRITE, 0L, j);
            this.brY = map2;
            map2.order(ByteOrder.LITTLE_ENDIAN);
            this.brX.put(bVar.brL, 0, this.bsa);
            this.brY.put(bVar.brL, 0, this.bsa);
            return true;
        } catch (Exception e2) {
            z(e2);
            return false;
        }
    }

    private static void f(int i, boolean z) {
        if (z) {
            if (i != 32) {
                throw new IllegalStateException("name size not match");
            }
        } else if (i < 0 || i >= 2048) {
            throw new IllegalStateException("value size out of bound");
        }
    }

    private void a(MappedByteBuffer mappedByteBuffer, MappedByteBuffer mappedByteBuffer2, int i) {
        if (mappedByteBuffer.capacity() != mappedByteBuffer2.capacity()) {
            try {
                MappedByteBuffer map = (mappedByteBuffer2 == this.brY ? this.brU : this.brT).map(FileChannel.MapMode.READ_WRITE, 0L, mappedByteBuffer.capacity());
                map.order(ByteOrder.LITTLE_ENDIAN);
                if (mappedByteBuffer2 == this.brY) {
                    this.brY = map;
                } else {
                    this.brX = map;
                }
                mappedByteBuffer2 = map;
            } catch (Exception e2) {
                z(e2);
                XC();
                return;
            }
        }
        mappedByteBuffer.rewind();
        mappedByteBuffer2.rewind();
        mappedByteBuffer.limit(i);
        mappedByteBuffer2.put(mappedByteBuffer);
        mappedByteBuffer.limit(mappedByteBuffer.capacity());
    }

    private int Xx() {
        String string;
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        bVar.position = 12;
        while (true) {
            try {
                if (bVar.position < this.bsa) {
                    int i = bVar.position;
                    byte b2 = bVar.get();
                    byte b3 = (byte) (b2 & 63);
                    if (b3 <= 0 || b3 > 8) {
                        throw new Exception("parse dara failed");
                    }
                    int i2 = bVar.get() & UByte.MAX_VALUE;
                    if (b2 < 0) {
                        bVar.position += i2;
                        int i3 = b3 <= 5 ? brM[b3] : bVar.getShort() & UShort.MAX_VALUE;
                        this.brZ.position += i3;
                        N(i, this.brZ.position);
                    } else {
                        String string2 = bVar.getString(i2);
                        int i4 = bVar.position;
                        if (b3 > 5) {
                            int i5 = bVar.getShort() & UShort.MAX_VALUE;
                            boolean z = (b2 & 64) != 0;
                            f(i5, z);
                            if (b3 == 6) {
                                if (z) {
                                    string = bVar.fY(i5);
                                } else {
                                    string = bVar.getString(i5);
                                }
                                this.bsc.put(string2, new com.kwad.sdk.utils.a.a.i(i, i4 + 2, string, i5, z));
                            } else if (b3 == 7) {
                                this.bsc.put(string2, new com.kwad.sdk.utils.a.a.C0536a(i, i4 + 2, z ? bVar.getString(i5) : bVar.getBytes(i5), i5, z));
                            } else if (z) {
                                this.bsc.put(string2, new com.kwad.sdk.utils.a.a.h(i, i4 + 2, bVar.getString(i5), i5, true));
                            } else {
                                int i6 = bVar.get() & UByte.MAX_VALUE;
                                String string3 = bVar.getString(i6);
                                b bVar2 = this.brR.get(string3);
                                int i7 = i5 - (i6 + 1);
                                if (i7 < 0) {
                                    throw new Exception("parse dara failed");
                                }
                                if (bVar2 != null) {
                                    try {
                                        Object objF = bVar2.f(bVar.brL, bVar.position, i7);
                                        if (objF != null) {
                                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.h(i, i4 + 2, objF, i5, false));
                                        }
                                    } catch (Exception e2) {
                                        z(e2);
                                    }
                                } else {
                                    ix("object with tag: " + string3 + " without encoder");
                                }
                                bVar.position += i7;
                            }
                        } else if (b3 == 1) {
                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.c(i4, bVar.get() == 1));
                        } else if (b3 == 2) {
                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.f(i4, bVar.getInt()));
                        } else if (b3 == 3) {
                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.e(i4, bVar.getFloat()));
                        } else if (b3 == 4) {
                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.g(i4, bVar.getLong()));
                        } else {
                            this.bsc.put(string2, new com.kwad.sdk.utils.a.a.d(i4, bVar.getDouble()));
                        }
                    }
                } else {
                    if (bVar.position == this.bsa) {
                        return 0;
                    }
                    g(new Exception("parse dara failed"));
                    return -1;
                }
            } catch (Exception e3) {
                g(e3);
                return -1;
            }
        }
    }

    public final synchronized boolean contains(String str) {
        return this.bsc.containsKey(str);
    }

    public final synchronized boolean getBoolean(String str, boolean z) {
        com.kwad.sdk.utils.a.a.c cVar = (com.kwad.sdk.utils.a.a.c) this.bsc.get(str);
        if (cVar == null) {
            return z;
        }
        return cVar.value;
    }

    public final synchronized int getInt(String str, int i) {
        com.kwad.sdk.utils.a.a.f fVar = (com.kwad.sdk.utils.a.a.f) this.bsc.get(str);
        if (fVar == null) {
            return i;
        }
        return fVar.value;
    }

    public final synchronized long getLong(String str, long j) {
        com.kwad.sdk.utils.a.a.g gVar = (com.kwad.sdk.utils.a.a.g) this.bsc.get(str);
        if (gVar == null) {
            return j;
        }
        return gVar.value;
    }

    public final synchronized String getString(String str, String str2) {
        com.kwad.sdk.utils.a.a.i iVar = (com.kwad.sdk.utils.a.a.i) this.bsc.get(str);
        if (iVar == null) {
            return str2;
        }
        if (iVar.brJ) {
            return a(iVar);
        }
        return (String) iVar.value;
    }

    private String a(com.kwad.sdk.utils.a.a.i iVar) {
        byte[] bytes;
        try {
            byte[] bArrAh = h.ah(new File(this.app + this.name, (String) iVar.value));
            String str = new String(bArrAh);
            return (bArrAh == null || TextUtils.isEmpty(str) || (bytes = com.kwad.sdk.utils.a.b.j(bArrAh, com.kwad.sdk.utils.a.b.it(str)).getBytes()) == null || bytes.length == 0) ? "" : new String(bytes, com.kwad.sdk.utils.a.b.UTF_8);
        } catch (Exception e2) {
            z(e2);
        }
        return "";
    }

    private byte[] a(com.kwad.sdk.utils.a.a.C0536a c0536a) {
        try {
            byte[] bArrAh = h.ah(new File(this.app + this.name, (String) c0536a.value));
            return bArrAh != null ? bArrAh : brN;
        } catch (Exception e2) {
            z(e2);
            return brN;
        }
    }

    private Object a(com.kwad.sdk.utils.a.a.h hVar) {
        try {
            byte[] bArrAh = h.ah(new File(this.app + this.name, (String) hVar.value));
            if (bArrAh != null) {
                int i = bArrAh[0] & UByte.MAX_VALUE;
                String str = new String(bArrAh, 1, i, com.kwad.sdk.utils.a.b.UTF_8);
                b bVar = this.brR.get(str);
                if (bVar != null) {
                    int i2 = i + 1;
                    return bVar.f(bArrAh, i2, bArrAh.length - i2);
                }
                g(new Exception("No encoder for tag:".concat(str)));
                return null;
            }
            g(new Exception("Read object data failed"));
            return null;
        } catch (Exception e2) {
            z(e2);
            return null;
        }
    }

    public final synchronized void putBoolean(String str, boolean z) {
        iw(str);
        com.kwad.sdk.utils.a.a.c cVar = (com.kwad.sdk.utils.a.a.c) this.bsc.get(str);
        if (cVar == null) {
            a(str, (byte) 1);
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                int i = bVar.position;
                this.brZ.e((byte) (z ? 1 : 0));
                XF();
                Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
                if (map != null) {
                    map.put(str, new com.kwad.sdk.utils.a.a.c(i, z));
                }
            }
            Xy();
            return;
        }
        if (cVar.value != z) {
            cVar.value = z;
            a((byte) (z ? 1 : 0), cVar.offset);
            Xy();
        }
    }

    public final synchronized void putInt(String str, int i) {
        iw(str);
        com.kwad.sdk.utils.a.a.f fVar = (com.kwad.sdk.utils.a.a.f) this.bsc.get(str);
        if (fVar == null) {
            a(str, (byte) 2);
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                int i2 = bVar.position;
                this.brZ.fV(i);
                XF();
                Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
                if (map != null) {
                    map.put(str, new com.kwad.sdk.utils.a.a.f(i2, i));
                }
            }
            Xy();
            return;
        }
        if (fVar.value != i) {
            long j = ((long) (fVar.value ^ i)) & 4294967295L;
            fVar.value = i;
            b(i, j, fVar.offset);
            Xy();
        }
    }

    private synchronized void putFloat(String str, float f) {
        iw(str);
        com.kwad.sdk.utils.a.a.e eVar = (com.kwad.sdk.utils.a.a.e) this.bsc.get(str);
        if (eVar != null) {
            if (eVar.value != f) {
                int iFloatToRawIntBits = Float.floatToRawIntBits(f);
                long jFloatToRawIntBits = ((long) (Float.floatToRawIntBits(eVar.value) ^ iFloatToRawIntBits)) & 4294967295L;
                eVar.value = f;
                b(iFloatToRawIntBits, jFloatToRawIntBits, eVar.offset);
                Xy();
            }
            return;
        }
        a(str, (byte) 3);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            int i = bVar.position;
            this.brZ.fV(Float.floatToRawIntBits(f));
            XF();
            Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
            if (map != null) {
                map.put(str, new com.kwad.sdk.utils.a.a.e(i, f));
            }
        }
        Xy();
    }

    public final synchronized void putLong(String str, long j) {
        iw(str);
        com.kwad.sdk.utils.a.a.g gVar = (com.kwad.sdk.utils.a.a.g) this.bsc.get(str);
        if (gVar != null) {
            if (gVar.value != j) {
                long j2 = j ^ gVar.value;
                gVar.value = j;
                b(j, j2, gVar.offset);
                Xy();
            }
            return;
        }
        a(str, (byte) 4);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            int i = bVar.position;
            this.brZ.bd(j);
            XF();
            Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
            if (map != null) {
                map.put(str, new com.kwad.sdk.utils.a.a.g(i, j));
            }
        }
        Xy();
    }

    private synchronized void putDouble(String str, double d2) {
        iw(str);
        com.kwad.sdk.utils.a.a.d dVar = (com.kwad.sdk.utils.a.a.d) this.bsc.get(str);
        if (dVar != null) {
            if (dVar.value != d2) {
                long jDoubleToRawLongBits = Double.doubleToRawLongBits(d2);
                long jDoubleToRawLongBits2 = Double.doubleToRawLongBits(dVar.value) ^ jDoubleToRawLongBits;
                dVar.value = d2;
                b(jDoubleToRawLongBits, jDoubleToRawLongBits2, dVar.offset);
                Xy();
            }
            return;
        }
        a(str, (byte) 5);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            int i = bVar.position;
            this.brZ.bd(Double.doubleToRawLongBits(d2));
            XF();
            Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
            if (map != null) {
                map.put(str, new com.kwad.sdk.utils.a.a.d(i, d2));
            }
        }
        Xy();
    }

    public final synchronized void putString(String str, String str2) {
        byte[] bArrIv;
        byte[] bArr;
        byte[] bArr2;
        iw(str);
        if (str2 == null) {
            remove(str);
            return;
        }
        com.kwad.sdk.utils.a.a.i iVar = (com.kwad.sdk.utils.a.a.i) this.bsc.get(str);
        if (str2.length() * 3 < 2048) {
            a(str, str2, iVar);
            return;
        }
        if (str2.isEmpty()) {
            bArrIv = brN;
        } else {
            if (iVar == null && str2.length() < 2048) {
                int iIt = com.kwad.sdk.utils.a.b.it(str2);
                bArr = new byte[iIt];
                if (iIt == str2.length()) {
                    a(str2, 0, iIt, bArr, 0);
                    bArr2 = bArr;
                } else {
                    bArrIv = com.kwad.sdk.utils.a.b.iv(str2);
                }
            } else if (iVar != null && !iVar.brJ) {
                int iIt2 = com.kwad.sdk.utils.a.b.it(str2);
                bArr = new byte[iIt2];
                if (iIt2 == str2.length()) {
                    a(str2, 0, iIt2, bArr, 0);
                    bArr2 = bArr;
                } else {
                    bArrIv = com.kwad.sdk.utils.a.b.iv(str2);
                }
            } else {
                bArrIv = com.kwad.sdk.utils.a.b.iv(str2);
            }
            a(str, str2, bArr2, iVar, (byte) 6);
        }
        bArr2 = bArrIv;
        a(str, str2, bArr2, iVar, (byte) 6);
    }

    private synchronized void b(String str, byte[] bArr) {
        iw(str);
        if (bArr == null) {
            remove(str);
        } else {
            a(str, bArr, bArr, (com.kwad.sdk.utils.a.a.C0536a) this.bsc.get(str), (byte) 7);
        }
    }

    private synchronized <T> void a(String str, T t, b<T> bVar) {
        byte[] bArrU;
        iw(str);
        if (bVar == null) {
            IllegalArgumentException illegalArgumentException = new IllegalArgumentException("Encoder is null");
            if (com.kwad.library.a.a.oV.booleanValue()) {
                throw illegalArgumentException;
            }
            z(illegalArgumentException);
            return;
        }
        String strXM = bVar.XM();
        if (!strXM.isEmpty() && strXM.length() <= 50) {
            if (!this.brR.containsKey(strXM)) {
                IllegalArgumentException illegalArgumentException2 = new IllegalArgumentException("Encoder hasn't been registered");
                if (com.kwad.library.a.a.oV.booleanValue()) {
                    throw illegalArgumentException2;
                }
                z(illegalArgumentException2);
                return;
            }
            if (t == null) {
                remove(str);
                return;
            }
            try {
                bArrU = bVar.u(t);
            } catch (Exception e2) {
                z(e2);
                bArrU = null;
            }
            if (bArrU == null) {
                remove(str);
                return;
            }
            int iIt = com.kwad.sdk.utils.a.b.it(strXM);
            com.kwad.sdk.utils.a.b bVar2 = new com.kwad.sdk.utils.a.b(iIt + 1 + bArrU.length);
            bVar2.e((byte) iIt);
            bVar2.is(strXM);
            bVar2.p(bArrU);
            a(str, t, bVar2.brL, (com.kwad.sdk.utils.a.a.h) this.bsc.get(str), (byte) 8);
            return;
        }
        IllegalArgumentException illegalArgumentException3 = new IllegalArgumentException("Invalid encoder tag:" + strXM);
        if (com.kwad.library.a.a.oV.booleanValue()) {
            throw illegalArgumentException3;
        }
        z(illegalArgumentException3);
    }

    private synchronized void putStringSet(String str, Set<String> set) {
        try {
            if (set == null) {
                remove(str);
            } else {
                a(str, set, g.bsD);
            }
        } catch (Throwable th) {
            throw th;
        }
    }

    public final synchronized void remove(String str) {
        com.kwad.sdk.utils.a.a.b bVar = this.bsc.get(str);
        if (bVar != null) {
            this.bsc.remove(str);
            byte bXr = bVar.Xr();
            String str2 = null;
            if (bXr <= 5) {
                a(bXr, bVar.offset - (com.kwad.sdk.utils.a.b.it(str) + 2), bVar.offset + brM[bXr]);
            } else {
                com.kwad.sdk.utils.a.a.j jVar = (com.kwad.sdk.utils.a.a.j) bVar;
                a(bXr, jVar.start, jVar.offset + jVar.brI);
                if (jVar.brJ) {
                    str2 = (String) jVar.value;
                }
            }
            byte b2 = (byte) (bXr | ByteCompanionObject.MIN_VALUE);
            if (this.bsl == 0) {
                MappedByteBuffer mappedByteBuffer = this.brX;
                if (mappedByteBuffer != null) {
                    mappedByteBuffer.putLong(4, this.bsb);
                    this.brX.put(this.bsg, b2);
                }
                MappedByteBuffer mappedByteBuffer2 = this.brY;
                if (mappedByteBuffer2 != null) {
                    mappedByteBuffer2.putLong(4, this.bsb);
                    this.brY.put(this.bsg, b2);
                }
            } else {
                com.kwad.sdk.utils.a.b bVar2 = this.brZ;
                if (bVar2 != null) {
                    bVar2.h(4, this.bsb);
                }
            }
            this.bsg = 0;
            if (str2 != null) {
                h.h(new File(this.app + this.name, str2));
            }
            XI();
            Xy();
        }
    }

    public final synchronized Map<String, Object> getAll() {
        Object objValueOf;
        int size = this.bsc.size();
        if (size == 0) {
            return new HashMap();
        }
        HashMap map = new HashMap(((size * 4) / 3) + 1);
        for (Map.Entry<String, com.kwad.sdk.utils.a.a.b> entry : this.bsc.entrySet()) {
            String key = entry.getKey();
            com.kwad.sdk.utils.a.a.b value = entry.getValue();
            switch (value.Xr()) {
                case 1:
                    objValueOf = Boolean.valueOf(((com.kwad.sdk.utils.a.a.c) value).value);
                    break;
                case 2:
                    objValueOf = Integer.valueOf(((com.kwad.sdk.utils.a.a.f) value).value);
                    break;
                case 3:
                    objValueOf = Float.valueOf(((com.kwad.sdk.utils.a.a.e) value).value);
                    break;
                case 4:
                    objValueOf = Long.valueOf(((com.kwad.sdk.utils.a.a.g) value).value);
                    break;
                case 5:
                    objValueOf = Double.valueOf(((com.kwad.sdk.utils.a.a.d) value).value);
                    break;
                case 6:
                    com.kwad.sdk.utils.a.a.i iVar = (com.kwad.sdk.utils.a.a.i) value;
                    objValueOf = iVar.brJ ? a(iVar) : iVar.value;
                    break;
                case 7:
                    com.kwad.sdk.utils.a.a.C0536a c0536a = (com.kwad.sdk.utils.a.a.C0536a) value;
                    objValueOf = c0536a.brJ ? a(c0536a) : c0536a.value;
                    break;
                case 8:
                    com.kwad.sdk.utils.a.a.h hVar = (com.kwad.sdk.utils.a.a.h) value;
                    objValueOf = hVar.brJ ? a(hVar) : ((com.kwad.sdk.utils.a.a.h) value).value;
                    break;
                default:
                    objValueOf = null;
                    break;
            }
            map.put(key, objValueOf);
        }
        return map;
    }

    public final void putAll(Map<String, Object> map) {
        a(map, (Map<Class, b>) null);
    }

    private synchronized void a(Map<String, Object> map, Map<Class, b> map2) {
        if (map == null) {
            return;
        }
        for (Map.Entry<String, Object> entry : map.entrySet()) {
            String key = entry.getKey();
            Object value = entry.getValue();
            if (key != null && !key.isEmpty()) {
                if (value instanceof String) {
                    putString(key, (String) value);
                } else if (value instanceof Boolean) {
                    putBoolean(key, ((Boolean) value).booleanValue());
                } else if (value instanceof Integer) {
                    putInt(key, ((Integer) value).intValue());
                } else if (value instanceof Long) {
                    putLong(key, ((Long) value).longValue());
                } else if (value instanceof Float) {
                    putFloat(key, ((Float) value).floatValue());
                } else if (value instanceof Double) {
                    putDouble(key, ((Double) value).doubleValue());
                } else if (value instanceof Set) {
                    Set set = (Set) value;
                    if (!set.isEmpty() && (set.iterator().next() instanceof String)) {
                        putStringSet(key, (Set) value);
                    }
                } else if (value instanceof byte[]) {
                    b(key, (byte[]) value);
                } else {
                    g(new Exception("missing encoders"));
                }
            }
        }
    }

    private void Xy() {
        if (this.bsl == 0 || !this.bsm) {
            return;
        }
        Xz();
    }

    private boolean Xz() {
        int i = this.bsl;
        if (i == 1) {
            Executor executor = this.bsn;
            if (executor != null) {
                executor.execute(new Runnable() { // from class: com.kwad.sdk.utils.a.c.2
                    @Override // java.lang.Runnable
                    public final void run() {
                        c.this.XA();
                    }
                });
            }
        } else if (i == 2) {
            return XA();
        }
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized boolean XA() {
        try {
            File file = new File(this.app, this.name + ".tmp");
            if (h.ag(file)) {
                RandomAccessFile randomAccessFile = new RandomAccessFile(file, "rw");
                randomAccessFile.setLength(this.bsa);
                randomAccessFile.write(this.brZ.brL, 0, this.bsa);
                randomAccessFile.close();
                File file2 = new File(this.app, this.name + ".kvc");
                if (!file2.exists() || file2.delete()) {
                    if (file.renameTo(file2)) {
                        return true;
                    }
                    g(new Exception("rename failed"));
                }
            }
        } catch (Exception e2) {
            z(e2);
        }
        return false;
    }

    private void XB() {
        try {
            h.h(new File(this.app, this.name + ".kvc"));
            h.h(new File(this.app, this.name + ".tmp"));
        } catch (Exception e2) {
            z(e2);
        }
    }

    private void XC() {
        this.bsl = 1;
        h.closeQuietly(this.brT);
        h.closeQuietly(this.brU);
        this.brT = null;
        this.brU = null;
        this.brX = null;
        this.brY = null;
    }

    private void XD() {
        if (this.bsl == 0) {
            try {
                a(this.brX);
                a(this.brY);
            } catch (Throwable unused) {
                XC();
            }
        }
        XE();
        h.h(new File(this.app + this.name));
    }

    public final void release() {
        h.closeQuietly(this.brV);
        h.closeQuietly(this.brW);
        h.closeQuietly(this.brT);
        h.closeQuietly(this.brU);
        this.brT = null;
        this.brU = null;
        this.brX = null;
        this.brY = null;
        String str = this.app + this.name;
        C0537c c0537c = a.bsq;
        C0537c.remove(str);
    }

    private void a(MappedByteBuffer mappedByteBuffer) throws IOException {
        if (mappedByteBuffer == null) {
            return;
        }
        int iCapacity = mappedByteBuffer.capacity();
        int i = PAGE_SIZE;
        if (iCapacity != i) {
            FileChannel fileChannel = mappedByteBuffer == this.brX ? this.brT : this.brU;
            if (fileChannel == null) {
                return;
            }
            fileChannel.truncate(i);
            MappedByteBuffer map = fileChannel.map(FileChannel.MapMode.READ_WRITE, 0L, i);
            map.order(ByteOrder.LITTLE_ENDIAN);
            if (mappedByteBuffer == this.brX) {
                this.brX = map;
            } else {
                this.brY = map;
            }
            mappedByteBuffer = map;
        }
        mappedByteBuffer.putInt(0, 0);
        mappedByteBuffer.putLong(4, 0L);
    }

    private void XE() {
        this.bsa = 12;
        this.bsb = 0L;
        XK();
        this.bsc.clear();
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar == null || bVar.brL.length != PAGE_SIZE) {
            this.brZ = new com.kwad.sdk.utils.a.b(PAGE_SIZE);
        } else {
            this.brZ.J(0, 0);
            this.brZ.h(4, 0L);
        }
    }

    private static void iw(String str) {
        if (str == null || str.isEmpty()) {
            throw new IllegalArgumentException("key is empty");
        }
    }

    private static void gc(int i) {
        if (i > 255) {
            throw new IllegalArgumentException("key's length must less than 256");
        }
    }

    private void a(String str, byte b2) {
        a(str, b2, brM[b2]);
    }

    private void a(String str, byte b2, int i) {
        int iIt = com.kwad.sdk.utils.a.b.it(str);
        gc(iIt);
        this.bsf = iIt + 2 + i;
        XH();
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            bVar.e(b2);
        }
        u(str, iIt);
    }

    private void XF() {
        com.kwad.sdk.utils.a.b bVar;
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 != null) {
            this.bsb ^= bVar2.L(this.bse, this.bsf);
        }
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                mappedByteBuffer.putInt(0, -1);
                b(this.brX);
                this.brX.putInt(0, this.bsa - 12);
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                b(mappedByteBuffer2);
            }
        } else {
            if (this.bsh && (bVar = this.brZ) != null) {
                bVar.J(0, this.bsa - 12);
            }
            com.kwad.sdk.utils.a.b bVar3 = this.brZ;
            if (bVar3 != null) {
                bVar3.h(4, this.bsb);
            }
        }
        this.bsh = false;
        this.bsg = 0;
        this.bsf = 0;
    }

    private void b(MappedByteBuffer mappedByteBuffer) {
        if (mappedByteBuffer == null) {
            return;
        }
        if (this.bsh && mappedByteBuffer != this.brX) {
            mappedByteBuffer.putInt(0, this.bsa - 12);
        }
        mappedByteBuffer.putLong(4, this.bsb);
        int i = this.bsg;
        if (i != 0) {
            mappedByteBuffer.put(i, this.brZ.brL[this.bsg]);
        }
        if (this.bsf != 0) {
            mappedByteBuffer.position(this.bse);
            mappedByteBuffer.put(this.brZ.brL, this.bse, this.bsf);
        }
    }

    private int XG() {
        int i = this.bsa;
        if (i <= 16384) {
            return 4096;
        }
        return i <= 65536 ? 8192 : 16384;
    }

    private void gd(int i) {
        if (this.brZ == null) {
            this.brZ = new com.kwad.sdk.utils.a.b(PAGE_SIZE);
        }
        int length = this.brZ.brL.length;
        int i2 = this.bsa + i;
        if (i2 >= length) {
            int i3 = this.bsj;
            if (i3 > i && i3 > XG()) {
                ge(i);
                return;
            }
            int iM = M(length, i2);
            byte[] bArr = new byte[iM];
            System.arraycopy(this.brZ.brL, 0, bArr, 0, this.bsa);
            this.brZ.brL = bArr;
            if (this.bsl == 0) {
                try {
                    long j = iM;
                    MappedByteBuffer map = this.brT.map(FileChannel.MapMode.READ_WRITE, 0L, j);
                    this.brX = map;
                    map.order(ByteOrder.LITTLE_ENDIAN);
                    MappedByteBuffer map2 = this.brU.map(FileChannel.MapMode.READ_WRITE, 0L, j);
                    this.brY = map2;
                    map2.order(ByteOrder.LITTLE_ENDIAN);
                } catch (Throwable th) {
                    z(new Exception("map failed", th));
                    this.brZ.J(0, this.bsa - 12);
                    this.brZ.h(4, this.bsb);
                    XC();
                }
            }
        }
    }

    private void a(byte b2, int i) {
        long jG = this.bsb ^ g(1L, i);
        this.bsb = jG;
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                mappedByteBuffer.putLong(4, jG);
                this.brX.put(i, b2);
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                mappedByteBuffer2.putLong(4, this.bsb);
                this.brY.put(i, b2);
            }
        } else {
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                bVar.h(4, jG);
            }
        }
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 != null) {
            bVar2.brL[i] = b2;
        }
    }

    private void b(int i, long j, int i2) {
        long jG = g(j, i2) ^ this.bsb;
        this.bsb = jG;
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                mappedByteBuffer.putLong(4, jG);
                this.brX.putInt(i2, i);
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                mappedByteBuffer2.putLong(4, this.bsb);
                this.brY.putInt(i2, i);
            }
        } else {
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                bVar.h(4, jG);
            }
        }
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 != null) {
            bVar2.J(i2, i);
        }
    }

    private void b(long j, long j2, int i) {
        long jG = g(j2, i) ^ this.bsb;
        this.bsb = jG;
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                mappedByteBuffer.putLong(4, jG);
                this.brX.putLong(i, j);
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                mappedByteBuffer2.putLong(4, this.bsb);
                this.brY.putLong(i, j);
            }
        } else {
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                bVar.h(4, jG);
            }
        }
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 != null) {
            bVar2.h(i, j);
        }
    }

    private void updateBytes(int i, byte[] bArr) {
        int length = bArr.length;
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            this.bsb ^= bVar.L(i, length);
            this.brZ.position = i;
            this.brZ.p(bArr);
            this.bsb ^= this.brZ.L(i, length);
        }
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                mappedByteBuffer.putInt(0, -1);
                this.brX.putLong(4, this.bsb);
                this.brX.position(i);
                this.brX.put(bArr);
                this.brX.putInt(0, this.bsa - 12);
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                mappedByteBuffer2.putLong(4, this.bsb);
                this.brY.position(i);
                this.brY.put(bArr);
                return;
            }
            return;
        }
        com.kwad.sdk.utils.a.b bVar2 = this.brZ;
        if (bVar2 != null) {
            bVar2.h(4, this.bsb);
        }
    }

    private void XH() {
        gd(this.bsf);
        int i = this.bsa;
        this.bse = i;
        this.bsa = this.bsf + i;
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            bVar.position = i;
        }
        this.bsh = true;
    }

    private void u(String str, int i) {
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar == null) {
            return;
        }
        bVar.e((byte) i);
        if (i == str.length()) {
            a(str, 0, i, this.brZ.brL, this.brZ.position);
            this.brZ.position += i;
            return;
        }
        this.brZ.is(str);
    }

    private static void a(String str, int i, int i2, byte[] bArr, int i3) {
        int i4;
        if (i2 <= str.length() && i2 >= 0) {
            int i5 = 0;
            while (i5 < i2) {
                int i6 = i5 + 1;
                char cCharAt = str.charAt(i5);
                if (cCharAt < 128) {
                    i4 = i3 + 1;
                    bArr[i3] = (byte) (((byte) cCharAt) ^ 1);
                } else {
                    i4 = i3 + 1;
                    bArr[i3] = (byte) cCharAt;
                }
                i5 = i6;
                i3 = i4;
            }
        }
    }

    private void v(String str, int i) {
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar == null) {
            return;
        }
        bVar.a((short) i);
        if (i == str.length()) {
            a(str, 0, i, this.brZ.brL, this.brZ.position);
        } else {
            this.brZ.is(str);
        }
    }

    private void a(String str, String str2, com.kwad.sdk.utils.a.a.i iVar) {
        int iIt = com.kwad.sdk.utils.a.b.it(str2);
        if (iVar == null) {
            int iIt2 = com.kwad.sdk.utils.a.b.it(str);
            gc(iIt2);
            int i = iIt2 + 4;
            this.bsf = i + iIt;
            XH();
            com.kwad.sdk.utils.a.b bVar = this.brZ;
            if (bVar != null) {
                bVar.e((byte) 6);
            }
            u(str, iIt2);
            v(str2, iIt);
            Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
            int i2 = this.bse;
            map.put(str, new com.kwad.sdk.utils.a.a.i(i2, i2 + i, str2, iIt, false));
            XF();
        } else {
            int i3 = iVar.offset - iVar.start;
            boolean z = false;
            String str3 = null;
            if (iVar.brI == iIt) {
                this.bsb ^= this.brZ.L(iVar.offset, iVar.brI);
                if (iIt == str2.length()) {
                    a(str2, 0, iIt, this.brZ.brL, iVar.offset);
                } else {
                    com.kwad.sdk.utils.a.b bVar2 = this.brZ;
                    if (bVar2 != null) {
                        bVar2.position = iVar.offset;
                        this.brZ.is(str2);
                    }
                }
                this.bse = iVar.offset;
                this.bsf = iIt;
            } else {
                this.bsf = i3 + iIt;
                XH();
                com.kwad.sdk.utils.a.b bVar3 = this.brZ;
                if (bVar3 != null) {
                    bVar3.e((byte) 6);
                }
                int i4 = i3 - 3;
                com.kwad.sdk.utils.a.b bVar4 = this.brZ;
                if (bVar4 != null) {
                    System.arraycopy(bVar4.brL, iVar.start + 1, this.brZ.brL, this.brZ.position, i4);
                }
                com.kwad.sdk.utils.a.b bVar5 = this.brZ;
                if (bVar5 != null) {
                    bVar5.position += i4;
                }
                v(str2, iIt);
                a((byte) 6, iVar.start, iVar.offset + iVar.brI);
                str3 = iVar.brJ ? (String) iVar.value : null;
                iVar.brJ = false;
                iVar.start = this.bse;
                iVar.offset = this.bse + i3;
                iVar.brI = iIt;
                z = true;
            }
            iVar.value = str2;
            XF();
            if (z) {
                XI();
            }
            if (str3 != null) {
                h.h(new File(this.app + this.name, str3));
            }
        }
        Xy();
    }

    private void a(String str, Object obj, byte[] bArr, com.kwad.sdk.utils.a.a.j jVar, byte b2) {
        if (jVar == null) {
            a(str, obj, bArr, b2);
        } else if (jVar.brJ || jVar.brI != bArr.length) {
            a(str, obj, bArr, jVar);
        } else {
            updateBytes(jVar.offset, bArr);
            jVar.value = obj;
        }
        Xy();
    }

    private void a(String str, Object obj, byte[] bArr, byte b2) {
        Object obj2;
        int length;
        com.kwad.sdk.utils.a.a.b hVar;
        int iA = a(str, bArr, b2);
        if (iA != 0) {
            String str2 = this.bsi;
            boolean z = str2 != null;
            if (z) {
                this.bsi = null;
                length = 32;
                obj2 = str2;
            } else {
                obj2 = obj;
                length = bArr.length;
            }
            if (b2 == 6) {
                hVar = new com.kwad.sdk.utils.a.a.i(this.bse, iA, (String) obj2, length, z);
            } else if (b2 == 7) {
                hVar = new com.kwad.sdk.utils.a.a.C0536a(this.bse, iA, obj2, length, z);
            } else {
                hVar = new com.kwad.sdk.utils.a.a.h(this.bse, iA, obj2, length, z);
            }
            this.bsc.put(str, hVar);
            XF();
        }
    }

    private void a(String str, Object obj, byte[] bArr, com.kwad.sdk.utils.a.a.j jVar) {
        int iA = a(str, bArr, jVar.Xr());
        if (iA != 0) {
            String str2 = jVar.brJ ? (String) jVar.value : null;
            a(jVar.Xr(), jVar.start, jVar.offset + jVar.brI);
            boolean z = this.bsi != null;
            jVar.start = this.bse;
            jVar.offset = iA;
            jVar.brJ = z;
            if (z) {
                jVar.value = this.bsi;
                jVar.brI = 32;
                this.bsi = null;
            } else {
                jVar.value = obj;
                jVar.brI = bArr.length;
            }
            XF();
            XI();
            if (str2 != null) {
                h.h(new File(this.app + this.name, str2));
            }
        }
    }

    private int a(String str, byte[] bArr, byte b2) {
        this.bsi = null;
        if (bArr.length < 2048) {
            return b(str, bArr, b2);
        }
        info("large value, key: " + str + ", size: " + bArr.length);
        String strXN = h.XN();
        if (h.a(new File(this.app + this.name, strXN), bArr)) {
            this.bsi = strXN;
            byte[] bArr2 = new byte[32];
            strXN.getBytes(0, 32, bArr2, 0);
            return b(str, bArr2, (byte) (b2 | 64));
        }
        ix("save large value failed");
        return 0;
    }

    private int b(String str, byte[] bArr, byte b2) {
        a(str, b2, bArr.length + 2);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar == null) {
            return 0;
        }
        bVar.a((short) bArr.length);
        int i = this.brZ.position;
        this.brZ.p(bArr);
        return i;
    }

    private void a(byte b2, int i, int i2) {
        N(i, i2);
        byte b3 = (byte) (b2 | ByteCompanionObject.MIN_VALUE);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null && bVar.brL != null) {
            this.bsb ^= (((long) (this.brZ.brL[i] ^ b3)) & 255) << ((i & 7) << 3);
            this.brZ.brL[i] = b3;
        }
        this.bsg = i;
    }

    private void XI() {
        if (this.bsj < (XG() << 1)) {
            if (this.bsk.size() < (this.bsa < 16384 ? 80 : 160)) {
                return;
            }
        }
        ge(0);
    }

    private void XJ() {
        ArrayList<e> arrayList = this.bsk;
        if (arrayList == null) {
            return;
        }
        int size = arrayList.size() - 1;
        e eVar = this.bsk.get(size);
        while (size > 0) {
            size--;
            e eVar2 = this.bsk.get(size);
            if (eVar.start == eVar2.end) {
                eVar2.end = eVar.end;
                this.bsk.remove(size + 1);
            }
            eVar = eVar2;
        }
    }

    private void ge(int i) {
        int i2;
        ArrayList<e> arrayList = this.bsk;
        if (arrayList == null || this.brZ == null) {
            return;
        }
        Collections.sort(arrayList);
        XJ();
        e eVar = this.bsk.get(0);
        int i3 = eVar.start;
        int i4 = this.bsa;
        int i5 = i4 - this.bsj;
        int i6 = i5 - 12;
        int i7 = i5 - i3;
        int i8 = i4 - i3;
        boolean z = i6 < i8 + i7;
        if (!z) {
            this.bsb ^= this.brZ.L(i3, i8);
        }
        int size = this.bsk.size();
        int i9 = size - 1;
        int i10 = this.bsa - this.bsk.get(i9).end;
        int[] iArr = new int[(i10 > 0 ? size : i9) << 1];
        int i11 = eVar.start;
        int i12 = eVar.end;
        int i13 = 1;
        while (i13 < size) {
            e eVar2 = this.bsk.get(i13);
            int i14 = eVar2.start - i12;
            int i15 = size;
            System.arraycopy(this.brZ.brL, i12, this.brZ.brL, i11, i14);
            int i16 = (i13 - 1) << 1;
            iArr[i16] = i12;
            iArr[i16 + 1] = i12 - i11;
            i11 += i14;
            i12 = eVar2.end;
            i13++;
            size = i15;
        }
        if (i10 > 0) {
            System.arraycopy(this.brZ.brL, i12, this.brZ.brL, i11, i10);
            int i17 = i9 << 1;
            iArr[i17] = i12;
            iArr[i17 + 1] = i12 - i11;
        }
        XK();
        if (z) {
            this.bsb = this.brZ.L(12, i6);
        } else {
            this.bsb ^= this.brZ.L(i3, i7);
        }
        this.bsa = i5;
        if (this.bsl == 0) {
            MappedByteBuffer mappedByteBuffer = this.brX;
            if (mappedByteBuffer != null) {
                i2 = 0;
                mappedByteBuffer.putInt(0, -1);
                this.brX.putLong(4, this.bsb);
                this.brX.position(i3);
                this.brX.put(this.brZ.brL, i3, i7);
                this.brX.putInt(0, i6);
            } else {
                i2 = 0;
            }
            MappedByteBuffer mappedByteBuffer2 = this.brY;
            if (mappedByteBuffer2 != null) {
                mappedByteBuffer2.putInt(i2, i6);
                this.brY.putLong(4, this.bsb);
                this.brY.position(i3);
                this.brY.put(this.brZ.brL, i3, i7);
            }
        } else {
            this.brZ.J(0, i6);
            this.brZ.h(4, this.bsb);
        }
        a(i3, iArr);
        int i18 = i5 + i;
        if (this.brZ.brL.length - i18 > brQ) {
            gf(i18);
        }
        info("gc finish");
    }

    private void a(int i, int[] iArr) {
        Map<String, com.kwad.sdk.utils.a.a.b> map = this.bsc;
        if (map == null) {
            return;
        }
        for (com.kwad.sdk.utils.a.a.b bVar : map.values()) {
            if (bVar.offset > i) {
                int i2 = iArr[(h.binarySearch(iArr, bVar.offset) << 1) + 1];
                bVar.offset -= i2;
                if (bVar.Xr() >= 6) {
                    ((com.kwad.sdk.utils.a.a.j) bVar).start -= i2;
                }
            }
        }
    }

    private void gf(int i) {
        int i2 = PAGE_SIZE;
        int iM = M(i2, i + i2);
        com.kwad.sdk.utils.a.b bVar = this.brZ;
        if (bVar != null) {
            if (iM >= bVar.brL.length) {
                return;
            }
            byte[] bArr = new byte[iM];
            System.arraycopy(this.brZ.brL, 0, bArr, 0, this.bsa);
            this.brZ.brL = bArr;
        }
        if (this.bsl == 0) {
            try {
                long j = iM;
                this.brT.truncate(j);
                MappedByteBuffer map = this.brT.map(FileChannel.MapMode.READ_WRITE, 0L, j);
                this.brX = map;
                map.order(ByteOrder.LITTLE_ENDIAN);
                this.brU.truncate(j);
                MappedByteBuffer map2 = this.brU.map(FileChannel.MapMode.READ_WRITE, 0L, j);
                this.brY = map2;
                map2.order(ByteOrder.LITTLE_ENDIAN);
            } catch (Throwable th) {
                z(new Exception("map failed", th));
                XC();
            }
        }
        info("truncate finish");
    }

    private int M(int i, int i2) {
        if (i2 > 536870912) {
            IllegalStateException illegalStateException = new IllegalStateException("data size out of limit");
            if (com.kwad.library.a.a.oV.booleanValue()) {
                throw illegalStateException;
            }
            z(illegalStateException);
        }
        int i3 = PAGE_SIZE;
        if (i2 <= i3) {
            return i3;
        }
        while (i < i2) {
            int i4 = brP;
            i = i <= i4 ? i << 1 : i + i4;
        }
        return i;
    }

    private void N(int i, int i2) {
        this.bsj += i2 - i;
        ArrayList<e> arrayList = this.bsk;
        if (arrayList != null) {
            arrayList.add(new e(i, i2));
        }
    }

    private void XK() {
        this.bsj = 0;
        ArrayList<e> arrayList = this.bsk;
        if (arrayList != null) {
            arrayList.clear();
        }
    }

    static class e implements Comparable<e> {
        int end;
        int start;

        e(int i, int i2) {
            this.start = i;
            this.end = i2;
        }

        /* JADX INFO: Access modifiers changed from: private */
        @Override // java.lang.Comparable
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public int compareTo(e eVar) {
            return this.start - eVar.start;
        }
    }

    private void ix(String str) {
        d dVar = this.brS;
        if (dVar != null) {
            dVar.e(this.name, new Exception(str));
        }
    }

    private void z(Throwable th) {
        d dVar = this.brS;
        if (dVar != null) {
            dVar.e(this.name, th);
        }
    }

    private void g(Exception exc) {
        d dVar = this.brS;
        if (dVar != null) {
            dVar.a(this.name, exc);
        }
    }

    private void info(String str) {
        d dVar = this.brS;
        if (dVar != null) {
            dVar.i(this.name, str);
        }
    }

    /* JADX INFO: renamed from: com.kwad.sdk.utils.a.c$c, reason: collision with other inner class name */
    static class C0537c {
        private static Map<String, c> bss;
        private static List<String> bst;
        private static int bsu;
        public static Map<String, Integer> bsv;

        private static int getSize(int i) {
            return (int) ((i / 0.75f) + 1.0f);
        }

        public C0537c(int i) {
            int size = getSize(i);
            bss = new ConcurrentHashMap(size);
            bsv = new HashMap(size);
            bst = new CopyOnWriteArrayList();
            bsu = i;
        }

        private static void gg(int i) {
            com.kwad.sdk.utils.a.d.bsw.i("Ks_UnionKv", "reSize:" + i);
            bsu = i;
        }

        public static c iy(String str) {
            if (bss == null) {
                bss = new ConcurrentHashMap(getSize(bsu));
            }
            if (bst == null) {
                bst = new CopyOnWriteArrayList();
            }
            c cVar = bss.get(str);
            if (cVar == null) {
                return null;
            }
            bst.remove(str);
            bst.add(str);
            return cVar;
        }

        public static void b(String str, c cVar) {
            if (bss == null) {
                bss = new ConcurrentHashMap(getSize(bsu));
            }
            if (bst == null) {
                bst = new CopyOnWriteArrayList();
            }
            if (bss.containsKey(str)) {
                bst.remove(str);
                bst.add(str);
            } else {
                bst.add(str);
            }
            bss.put(str, cVar);
            if (bss.size() > bsu) {
                Integer num = bsv.get(bst.get(0));
                if (num != null && num.intValue() != 2) {
                    gg(bsu + 1);
                    return;
                }
                c cVar2 = bss.get(bst.get(0));
                if (cVar2 != null) {
                    cVar2.release();
                }
                bss.remove(bst.get(0));
                bst.remove(0);
            }
        }

        public static void remove(String str) {
            List<String> list = bst;
            if (list != null) {
                list.remove(str);
            }
            Map<String, c> map = bss;
            if (map != null) {
                map.remove(str);
            }
        }
    }

    public static class a {
        static int bsp = 11;
        static final C0537c bsq = new C0537c(bsp);
        private final String app;
        private int bsl = 0;
        private b[] bsr;
        private final String name;

        public a(String str, String str2) {
            if (str == null || str.isEmpty()) {
                throw new IllegalArgumentException("path is empty");
            }
            if (str2 == null || str2.isEmpty()) {
                throw new IllegalArgumentException("name is empty");
            }
            this.app = str.endsWith("/") ? str : str + '/';
            this.name = str2;
        }

        public final c XL() {
            String str = this.app + this.name;
            c cVarIy = C0537c.iy(str);
            if (cVarIy == null) {
                synchronized (a.class) {
                    cVarIy = C0537c.iy(str);
                    if (cVarIy == null) {
                        cVarIy = new c(this.app, this.name, this.bsr, this.bsl);
                        C0537c.b(str, cVarIy);
                    }
                }
            }
            Integer num = C0537c.bsv.get(str);
            if (num != null) {
                C0537c.bsv.put(str, Integer.valueOf(num.intValue() + 1));
            } else {
                C0537c.bsv.put(str, 1);
            }
            return cVarIy;
        }
    }

    public final synchronized String toString() {
        return "FastKV: path:" + this.app + " name:" + this.name;
    }
}
