package com.bytedance.ads.convert.flat.c;

import android.content.Context;
import android.net.Network;
import android.os.Build;
import android.text.TextUtils;
import com.bytedance.ads.convert.flat.m.d;
import com.bytedance.ads.convert.flat.m.e;
import com.bytedance.ads.convert.flat.m.g;
import com.bytedance.ads.convert.flat.m.h;
import com.bytedance.ads.convert.flat.m.i;
import com.bytedance.ads.convert.flat.m.j;
import com.bytedance.ads.convert.flat.m.k;
import com.bytedance.ads.convert.flat.m.l;
import com.bytedance.ads.convert.flat.m.m;
import com.bytedance.ads.convert.flat.m.n;
import com.bytedance.ads.convert.flat.m.p;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.URL;
import java.nio.BufferUnderflowException;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.nio.channels.FileChannel;
import java.nio.charset.StandardCharsets;
import java.util.LinkedHashMap;
import java.util.Locale;
import java.util.Map;
import javax.net.ssl.HttpsURLConnection;

/* JADX INFO: loaded from: classes2.dex */
public class b {

    public interface a {
        void a();

        void a(String str);
    }

    /* JADX WARN: Code duplicated, block: B:100:0x013b  */
    /* JADX WARN: Code duplicated, block: B:101:0x0140  */
    /* JADX WARN: Code duplicated, block: B:112:0x0165  */
    /* JADX WARN: Code duplicated, block: B:114:0x0168  */
    /* JADX WARN: Code duplicated, block: B:116:0x016e  */
    /* JADX WARN: Code duplicated, block: B:118:0x017e  */
    /* JADX WARN: Code duplicated, block: B:120:0x0184  */
    /* JADX WARN: Code duplicated, block: B:122:0x018f A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:123:0x0190  */
    /* JADX WARN: Code duplicated, block: B:128:0x01a7  */
    /* JADX WARN: Code duplicated, block: B:136:0x0196 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:37:0x006a  */
    /* JADX WARN: Code duplicated, block: B:43:0x007b  */
    /* JADX WARN: Code duplicated, block: B:47:0x0084  */
    /* JADX WARN: Code duplicated, block: B:49:0x0094  */
    /* JADX WARN: Code duplicated, block: B:51:0x009a  */
    /* JADX WARN: Code duplicated, block: B:65:0x00c6  */
    /* JADX WARN: Code duplicated, block: B:67:0x00cc  */
    /* JADX WARN: Code duplicated, block: B:73:0x00dd  */
    /* JADX WARN: Code duplicated, block: B:76:0x00e1  */
    /* JADX WARN: Code duplicated, block: B:78:0x00e7  */
    /* JADX WARN: Code duplicated, block: B:80:0x00f5  */
    /* JADX WARN: Code duplicated, block: B:82:0x00fb  */
    /* JADX WARN: Code duplicated, block: B:84:0x0101  */
    /* JADX WARN: Code duplicated, block: B:90:0x0112  */
    /* JADX WARN: Code duplicated, block: B:92:0x0115  */
    /* JADX WARN: Code duplicated, block: B:94:0x011b  */
    /* JADX WARN: Code duplicated, block: B:96:0x012b  */
    /* JADX WARN: Code duplicated, block: B:98:0x0131  */
    public static com.bytedance.ads.convert.flat.k.c a(Context context) {
        boolean z;
        boolean z2;
        boolean z3;
        String str;
        Map<String, Object> map;
        Object objA;
        String str2;
        d dVar;
        String str3 = Build.BRAND;
        if (str3.equals("Pico")) {
            return new m();
        }
        int i = com.bytedance.ads.convert.flat.n.b.f1743a;
        String str4 = Build.MANUFACTURER;
        boolean zContains = true;
        if ("oppo".equalsIgnoreCase(str4) || "oppo".equalsIgnoreCase(str3) || "realme".equalsIgnoreCase(str3)) {
            return new l(new p());
        }
        if (str4.equalsIgnoreCase("XIAOMI") || str3.equalsIgnoreCase("XIAOMI") || str3.equalsIgnoreCase("REDMI")) {
            if (!((p.b == null || p.f1742a == null || p.c == null) ? false : true)) {
                if ("BlackShark".equalsIgnoreCase(str4)) {
                    z = true;
                } else {
                    z = true;
                }
                if (!z) {
                    if (k.f1737a.b(new Object[0]).booleanValue()) {
                        return new k();
                    }
                    if (!com.bytedance.ads.convert.flat.n.b.b()) {
                    }
                    if (!com.bytedance.ads.convert.flat.n.b.b()) {
                    }
                    if ("HUAWEI".equalsIgnoreCase(str4)) {
                        return new e();
                    }
                    if ("OnePlus".equalsIgnoreCase(str4)) {
                        z2 = true;
                    } else {
                        z2 = true;
                    }
                    if (z2) {
                        return new l(null);
                    }
                    if (str3.toLowerCase(Locale.ENGLISH).contains("meizu")) {
                        return new i();
                    }
                    if (Build.VERSION.SDK_INT > 28) {
                        if (Class.forName("miui.os.Build").getName().length() > 0) {
                        }
                        if (zContains) {
                        }
                        return null;
                    }
                    if ("samsung".equalsIgnoreCase(str3)) {
                        z3 = true;
                    } else {
                        z3 = true;
                    }
                    if (z3) {
                        return new n();
                    }
                    if (str4.trim().toUpperCase().contains("NUBIA")) {
                        return new j();
                    }
                    str = Build.FINGERPRINT;
                    if (TextUtils.isEmpty(str)) {
                        map = com.bytedance.ads.convert.flat.n.e.b;
                        objA = map.get("ro.build.version.incremental");
                        if (objA == null) {
                            map.put("ro.build.version.incremental", objA);
                        }
                        str2 = (String) objA;
                        if (TextUtils.isEmpty(str2)) {
                            zContains = false;
                        } else {
                            zContains = false;
                        }
                    } else {
                        zContains = str.contains("VIBEUI_V2");
                    }
                    if (zContains) {
                        return new h();
                    }
                    if (str4.trim().toUpperCase().contains("ASUS")) {
                        return new com.bytedance.ads.convert.flat.m.a();
                    }
                    dVar = new d(context);
                    if (dVar.b(context)) {
                        return dVar;
                    }
                    return new com.bytedance.ads.convert.flat.m.c();
                }
            }
        } else {
            if ("BlackShark".equalsIgnoreCase(str4) || "BlackShark".equalsIgnoreCase(str3)) {
                z = true;
            } else {
                z = false;
            }
            if (!z) {
                if (k.f1737a.b(new Object[0]).booleanValue()) {
                    return new k();
                }
                if (!com.bytedance.ads.convert.flat.n.b.b() && com.bytedance.ads.convert.flat.n.b.a()) {
                    return new e();
                }
                if (!com.bytedance.ads.convert.flat.n.b.b() && !com.bytedance.ads.convert.flat.n.b.a()) {
                    return new g();
                }
                if ("HUAWEI".equalsIgnoreCase(str4)) {
                    return new e();
                }
                if ("OnePlus".equalsIgnoreCase(str4) || "OnePlus".equalsIgnoreCase(str3)) {
                    z2 = true;
                } else {
                    z2 = false;
                }
                if (z2) {
                    return new l(null);
                }
                if (str3.toLowerCase(Locale.ENGLISH).contains("meizu")) {
                    return new i();
                }
                if (Build.VERSION.SDK_INT > 28) {
                    try {
                        zContains = Class.forName("miui.os.Build").getName().length() > 0;
                    } catch (Exception unused) {
                    }
                    if (zContains && e.c(context)) {
                        return new e();
                    }
                    return null;
                }
                if ("samsung".equalsIgnoreCase(str3) || "samsung".equalsIgnoreCase(str4)) {
                    z3 = true;
                } else {
                    z3 = false;
                }
                if (z3) {
                    return new n();
                }
                if (str4.trim().toUpperCase().contains("NUBIA")) {
                    return new j();
                }
                str = Build.FINGERPRINT;
                if (TextUtils.isEmpty(str)) {
                    zContains = str.contains("VIBEUI_V2");
                } else {
                    map = com.bytedance.ads.convert.flat.n.e.b;
                    objA = map.get("ro.build.version.incremental");
                    if (objA == null && (objA = com.bytedance.ads.convert.flat.n.e.f1746a.a("ro.build.version.incremental")) != null) {
                        map.put("ro.build.version.incremental", objA);
                    }
                    str2 = (String) objA;
                    if (TextUtils.isEmpty(str2) || !str2.contains("VIBEUI_V2")) {
                        zContains = false;
                    }
                }
                if (zContains) {
                    return new h();
                }
                if (str4.trim().toUpperCase().contains("ASUS")) {
                    return new com.bytedance.ads.convert.flat.m.a();
                }
                dVar = new d(context);
                if (dVar.b(context)) {
                    return dVar;
                }
                return new com.bytedance.ads.convert.flat.m.c();
            }
        }
        return new p();
    }

    public static void a(Network network, String str, String str2, a aVar) {
        InputStream inputStream;
        OutputStream outputStream;
        if (str == null) {
            aVar.a();
            return;
        }
        HttpsURLConnection httpsURLConnection = null;
        InputStream inputStream2 = null;
        try {
            HttpsURLConnection httpsURLConnection2 = (HttpsURLConnection) (network != null ? network.openConnection(new URL(str)) : new URL(str).openConnection());
            try {
                if (httpsURLConnection2 == null) {
                    aVar.a();
                    if (httpsURLConnection2 != null) {
                        httpsURLConnection2.disconnect();
                        return;
                    }
                    return;
                }
                httpsURLConnection2.setRequestMethod("POST");
                httpsURLConnection2.setConnectTimeout(10000);
                httpsURLConnection2.setReadTimeout(10000);
                httpsURLConnection2.setDoInput(true);
                httpsURLConnection2.setDefaultUseCaches(false);
                if (str2 != null) {
                    httpsURLConnection2.setDoOutput(true);
                    outputStream = httpsURLConnection2.getOutputStream();
                    try {
                        outputStream.write(str2.getBytes());
                        outputStream.flush();
                    } catch (Throwable unused) {
                        httpsURLConnection = httpsURLConnection2;
                        inputStream = null;
                        try {
                            aVar.a();
                            if (httpsURLConnection != null) {
                                httpsURLConnection.disconnect();
                            }
                            if (outputStream != null) {
                                try {
                                    outputStream.close();
                                } catch (IOException e) {
                                    throw new RuntimeException(e);
                                }
                            }
                            if (inputStream != null) {
                                inputStream.close();
                                return;
                            }
                            return;
                        } catch (Throwable th) {
                            if (httpsURLConnection != null) {
                                httpsURLConnection.disconnect();
                            }
                            if (outputStream != null) {
                                try {
                                    outputStream.close();
                                } catch (IOException e2) {
                                    throw new RuntimeException(e2);
                                }
                            }
                            if (inputStream != null) {
                                inputStream.close();
                            }
                            throw th;
                        }
                    }
                } else {
                    outputStream = null;
                }
                httpsURLConnection2.connect();
                if (httpsURLConnection2.getResponseCode() == 200) {
                    inputStream2 = httpsURLConnection2.getInputStream();
                    byte[] bArr = new byte[2048];
                    StringBuilder sb = new StringBuilder();
                    while (true) {
                        int i = inputStream2.read(bArr);
                        if (i <= 0) {
                            break;
                        } else {
                            sb.append(new String(bArr, 0, i, StandardCharsets.UTF_8));
                        }
                    }
                    aVar.a(sb.toString());
                } else {
                    aVar.a();
                }
                httpsURLConnection2.disconnect();
                if (outputStream != null) {
                    try {
                        outputStream.close();
                    } catch (IOException e3) {
                        throw new RuntimeException(e3);
                    }
                }
                if (inputStream2 != null) {
                    inputStream2.close();
                }
            } catch (Throwable unused2) {
                outputStream = null;
                httpsURLConnection = httpsURLConnection2;
                inputStream = null;
            }
        } catch (Throwable unused3) {
            inputStream = null;
            outputStream = null;
        }
    }

    public static com.bytedance.ads.convert.flat.g.a<ByteBuffer, Long> a(FileChannel fileChannel) throws IOException, com.bytedance.ads.convert.flat.g.b {
        long size = fileChannel.size();
        if (size < 22) {
            throw new IOException("APK too small for ZIP End of Central Directory (EOCD) record");
        }
        long j = size - 22;
        long jMin = Math.min(j, 65535L);
        int i = 0;
        while (true) {
            long j2 = i;
            if (j2 > jMin) {
                throw new IOException("ZIP End of Central Directory (EOCD) record not found");
            }
            long j3 = j - j2;
            ByteBuffer byteBufferAllocate = ByteBuffer.allocate(4);
            fileChannel.position(j3);
            fileChannel.read(byteBufferAllocate);
            ByteOrder byteOrder = ByteOrder.LITTLE_ENDIAN;
            byteBufferAllocate.order(byteOrder);
            if (byteBufferAllocate.getInt(0) == 101010256) {
                ByteBuffer byteBufferAllocate2 = ByteBuffer.allocate(2);
                fileChannel.position(j3 + 20);
                fileChannel.read(byteBufferAllocate2);
                byteBufferAllocate2.order(byteOrder);
                short s = byteBufferAllocate2.getShort(0);
                if (s == i) {
                    ByteBuffer byteBufferAllocate3 = ByteBuffer.allocate(4);
                    byteBufferAllocate3.order(byteOrder);
                    fileChannel.position((fileChannel.size() - ((long) s)) - 6);
                    fileChannel.read(byteBufferAllocate3);
                    long j4 = byteBufferAllocate3.getInt(0);
                    if (j4 < 0) {
                        fileChannel.read(byteBufferAllocate3);
                        byte[] bArr = new byte[8];
                        for (int i2 = 4; i2 < 8; i2++) {
                            bArr[i2] = byteBufferAllocate3.get((8 - i2) - 1);
                        }
                        j4 = ByteBuffer.wrap(bArr).getLong();
                    }
                    if (j4 < 32) {
                        throw new com.bytedance.ads.convert.flat.g.b("APK too small for APK Signing Block. ZIP Central Directory offset: " + j4);
                    }
                    fileChannel.position(j4 - 24);
                    ByteBuffer byteBufferAllocate4 = ByteBuffer.allocate(24);
                    fileChannel.read(byteBufferAllocate4);
                    ByteOrder byteOrder2 = ByteOrder.LITTLE_ENDIAN;
                    byteBufferAllocate4.order(byteOrder2);
                    if (byteBufferAllocate4.getLong(8) != 2334950737559900225L || byteBufferAllocate4.getLong(16) != 3617552046287187010L) {
                        throw new com.bytedance.ads.convert.flat.g.b("No APK Signing Block before ZIP Central Directory");
                    }
                    long j5 = byteBufferAllocate4.getLong(0);
                    if (j5 < byteBufferAllocate4.capacity() || j5 > 2147483639) {
                        throw new com.bytedance.ads.convert.flat.g.b("APK Signing Block size out of range: " + j5);
                    }
                    int i3 = (int) (8 + j5);
                    long j6 = j4 - ((long) i3);
                    if (j6 < 0) {
                        throw new com.bytedance.ads.convert.flat.g.b("APK Signing Block offset out of range: " + j6);
                    }
                    fileChannel.position(j6);
                    ByteBuffer byteBufferAllocate5 = ByteBuffer.allocate(i3);
                    fileChannel.read(byteBufferAllocate5);
                    byteBufferAllocate5.order(byteOrder2);
                    long j7 = byteBufferAllocate5.getLong(0);
                    if (j7 == j5) {
                        return new com.bytedance.ads.convert.flat.g.a<>(byteBufferAllocate5, Long.valueOf(j6));
                    }
                    throw new com.bytedance.ads.convert.flat.g.b("APK Signing Block sizes in header and footer do not match: " + j7 + " vs " + j5);
                }
            }
            i++;
        }
    }

    public static Map<Integer, ByteBuffer> a(ByteBuffer byteBuffer) throws com.bytedance.ads.convert.flat.g.b {
        if (byteBuffer.order() == ByteOrder.LITTLE_ENDIAN) {
            int iCapacity = byteBuffer.capacity() - 24;
            if (iCapacity < 8) {
                throw new IllegalArgumentException("end < start: " + iCapacity + " < 8");
            }
            int iCapacity2 = byteBuffer.capacity();
            if (iCapacity > byteBuffer.capacity()) {
                throw new IllegalArgumentException("end > capacity: " + iCapacity + " > " + iCapacity2);
            }
            int iLimit = byteBuffer.limit();
            int iPosition = byteBuffer.position();
            int i = 0;
            try {
                byteBuffer.position(0);
                byteBuffer.limit(iCapacity);
                byteBuffer.position(8);
                ByteBuffer byteBufferSlice = byteBuffer.slice();
                byteBufferSlice.order(byteBuffer.order());
                byteBuffer.position(0);
                byteBuffer.limit(iLimit);
                byteBuffer.position(iPosition);
                LinkedHashMap linkedHashMap = new LinkedHashMap();
                while (byteBufferSlice.hasRemaining()) {
                    i++;
                    if (byteBufferSlice.remaining() < 8) {
                        throw new com.bytedance.ads.convert.flat.g.b("Insufficient data to read size of APK Signing Block entry #" + i);
                    }
                    long j = byteBufferSlice.getLong();
                    if (j < 4 || j > 2147483647L) {
                        throw new com.bytedance.ads.convert.flat.g.b("APK Signing Block entry #" + i + " size out of range: " + j);
                    }
                    int i2 = (int) j;
                    int iPosition2 = byteBufferSlice.position() + i2;
                    if (i2 > byteBufferSlice.remaining()) {
                        throw new com.bytedance.ads.convert.flat.g.b("APK Signing Block entry #" + i + " size out of range: " + i2 + ", available: " + byteBufferSlice.remaining());
                    }
                    Integer numValueOf = Integer.valueOf(byteBufferSlice.getInt());
                    int i3 = i2 - 4;
                    if (i3 < 0) {
                        throw new IllegalArgumentException("size: " + i3);
                    }
                    int iLimit2 = byteBufferSlice.limit();
                    int iPosition3 = byteBufferSlice.position();
                    int i4 = i3 + iPosition3;
                    if (i4 < iPosition3 || i4 > iLimit2) {
                        throw new BufferUnderflowException();
                    }
                    byteBufferSlice.limit(i4);
                    try {
                        ByteBuffer byteBufferSlice2 = byteBufferSlice.slice();
                        byteBufferSlice2.order(byteBufferSlice.order());
                        byteBufferSlice.position(i4);
                        byteBufferSlice.limit(iLimit2);
                        linkedHashMap.put(numValueOf, byteBufferSlice2);
                        byteBufferSlice.position(iPosition2);
                    } catch (Throwable th) {
                        byteBufferSlice.limit(iLimit2);
                        throw th;
                    }
                }
                return linkedHashMap;
            } catch (Throwable th2) {
                byteBuffer.position(0);
                byteBuffer.limit(iLimit);
                byteBuffer.position(iPosition);
                throw th2;
            }
        }
        throw new IllegalArgumentException("ByteBuffer byte order must be little endian");
    }
}
