package com.tencent.turingfd.sdk.ams.ad;

import java.io.Serializable;
import java.io.UnsupportedEncodingException;
import java.lang.reflect.Array;
import java.nio.BufferUnderflowException;
import java.nio.ByteBuffer;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import kotlin.UByte;

/* JADX INFO: loaded from: classes4.dex */
public final class Perseus {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public ByteBuffer f3875a;
    public String b = "GBK";

    public Perseus() {
    }

    public final boolean a(int i) {
        int i2;
        while (true) {
            try {
                ByteBuffer byteBufferDuplicate = this.f3875a.duplicate();
                byte b = byteBufferDuplicate.get();
                byte b2 = (byte) (b & 15);
                int i3 = (b & 240) >> 4;
                if (i3 == 15) {
                    i3 = byteBufferDuplicate.get() & UByte.MAX_VALUE;
                    i2 = 2;
                } else {
                    i2 = 1;
                }
                if (b2 == 11 || i < i3) {
                    break;
                    break;
                }
                if (i == i3) {
                    return true;
                }
                ByteBuffer byteBuffer = this.f3875a;
                byteBuffer.position(byteBuffer.position() + i2);
                a(b2);
            } catch (Orion | BufferUnderflowException unused) {
            }
        }
        return false;
    }

    public final String b(int i, boolean z) {
        if (!a(i)) {
            if (z) {
                throw new Orion("require field not exist.");
            }
            return null;
        }
        ByteBuffer byteBuffer = this.f3875a;
        byte b = byteBuffer.get();
        byte b2 = (byte) (b & 15);
        if (((b & 240) >> 4) == 15) {
            byteBuffer.get();
        }
        if (b2 == 6) {
            int i2 = this.f3875a.get();
            if (i2 < 0) {
                i2 += 256;
            }
            byte[] bArr = new byte[i2];
            this.f3875a.get(bArr);
            try {
                return new String(bArr, this.b);
            } catch (UnsupportedEncodingException unused) {
                return new String(bArr);
            }
        }
        if (b2 != 7) {
            if (b2 == 11) {
                return null;
            }
            throw new Orion("type mismatch.");
        }
        int i3 = this.f3875a.getInt();
        if (i3 > 104857600 || i3 < 0) {
            throw new Orion("String too long: " + i3);
        }
        byte[] bArr2 = new byte[i3];
        this.f3875a.get(bArr2);
        try {
            return new String(bArr2, this.b);
        } catch (UnsupportedEncodingException unused2) {
            return new String(bArr2);
        }
    }

    public final void a(byte b) {
        int i = 0;
        switch (b) {
            case 0:
                ByteBuffer byteBuffer = this.f3875a;
                byteBuffer.position(byteBuffer.position() + 1);
                return;
            case 1:
                ByteBuffer byteBuffer2 = this.f3875a;
                byteBuffer2.position(byteBuffer2.position() + 2);
                return;
            case 2:
                ByteBuffer byteBuffer3 = this.f3875a;
                byteBuffer3.position(byteBuffer3.position() + 4);
                return;
            case 3:
                ByteBuffer byteBuffer4 = this.f3875a;
                byteBuffer4.position(byteBuffer4.position() + 8);
                return;
            case 4:
                ByteBuffer byteBuffer5 = this.f3875a;
                byteBuffer5.position(byteBuffer5.position() + 4);
                return;
            case 5:
                ByteBuffer byteBuffer6 = this.f3875a;
                byteBuffer6.position(byteBuffer6.position() + 8);
                return;
            case 6:
                int i2 = this.f3875a.get();
                if (i2 < 0) {
                    i2 += 256;
                }
                ByteBuffer byteBuffer7 = this.f3875a;
                byteBuffer7.position(byteBuffer7.position() + i2);
                return;
            case 7:
                int i3 = this.f3875a.getInt();
                ByteBuffer byteBuffer8 = this.f3875a;
                byteBuffer8.position(byteBuffer8.position() + i3);
                return;
            case 8:
                int iA = a(0, 0, true);
                while (i < iA * 2) {
                    ByteBuffer byteBuffer9 = this.f3875a;
                    byte b2 = byteBuffer9.get();
                    byte b3 = (byte) (b2 & 15);
                    if (((b2 & 240) >> 4) == 15) {
                        byteBuffer9.get();
                    }
                    a(b3);
                    i++;
                }
                return;
            case 9:
                int iA2 = a(0, 0, true);
                while (i < iA2) {
                    ByteBuffer byteBuffer10 = this.f3875a;
                    byte b4 = byteBuffer10.get();
                    byte b5 = (byte) (b4 & 15);
                    if (((b4 & 240) >> 4) == 15) {
                        byteBuffer10.get();
                    }
                    a(b5);
                    i++;
                }
                return;
            case 10:
                break;
            case 11:
            case 12:
                return;
            case 13:
                ByteBuffer byteBuffer11 = this.f3875a;
                byte b6 = byteBuffer11.get();
                byte b7 = (byte) (b6 & 15);
                if (((b6 & 240) >> 4) == 15) {
                    byteBuffer11.get();
                }
                if (b7 == 0) {
                    int iA3 = a(0, 0, true);
                    ByteBuffer byteBuffer12 = this.f3875a;
                    byteBuffer12.position(byteBuffer12.position() + iA3);
                    return;
                }
                throw new Orion("skipField with invalid type, type value: " + ((int) b) + ", " + ((int) b7));
            default:
                throw new Orion("invalid type.");
        }
        while (this.f3875a.remaining() != 0) {
            ByteBuffer byteBuffer13 = this.f3875a;
            byte b8 = byteBuffer13.get();
            byte b9 = (byte) (b8 & 15);
            if (((b8 & 240) >> 4) == 15) {
                byteBuffer13.get();
            }
            a(b9);
            if (b9 == 11) {
                return;
            }
        }
    }

    public final Object[] b(Object obj, int i, boolean z) {
        if (!a(i)) {
            if (z) {
                throw new Orion("require field not exist.");
            }
            return null;
        }
        ByteBuffer byteBuffer = this.f3875a;
        byte b = byteBuffer.get();
        byte b2 = (byte) (b & 15);
        if (((b & 240) >> 4) == 15) {
            byteBuffer.get();
        }
        if (b2 != 9) {
            if (b2 == 11) {
                return null;
            }
            throw new Orion("type mismatch.");
        }
        int iA = a(0, 0, true);
        if (iA >= 0) {
            Object[] objArr = (Object[]) Array.newInstance(obj.getClass(), iA);
            for (int i2 = 0; i2 < iA; i2++) {
                objArr[i2] = a(obj, 0, true);
            }
            return objArr;
        }
        throw new Orion("size invalid: " + iA);
    }

    public final boolean a(boolean z, int i, boolean z2) {
        return a(z ? (byte) 1 : (byte) 0, i, z2) != 0;
    }

    public final byte a(byte b, int i, boolean z) {
        if (a(i)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b2 = byteBuffer.get();
            byte b3 = (byte) (b2 & 15);
            if (((b2 & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b3 == 0) {
                return this.f3875a.get();
            }
            if (b3 != 11) {
                if (b3 == 12) {
                    return (byte) 0;
                }
                throw new Orion("type mismatch.");
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return b;
    }

    public final short a(short s, int i, boolean z) {
        if (a(i)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 == 0) {
                return this.f3875a.get();
            }
            if (b2 == 1) {
                return this.f3875a.getShort();
            }
            if (b2 != 11) {
                if (b2 == 12) {
                    return (short) 0;
                }
                throw new Orion("type mismatch.");
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return s;
    }

    public final int a(int i, int i2, boolean z) {
        if (a(i2)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 == 0) {
                return this.f3875a.get();
            }
            if (b2 == 1) {
                return this.f3875a.getShort();
            }
            if (b2 == 2) {
                return this.f3875a.getInt();
            }
            if (b2 != 11) {
                if (b2 == 12) {
                    return 0;
                }
                throw new Orion("type mismatch.");
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return i;
    }

    public final long a(long j, int i, boolean z) {
        if (a(i)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 != 11) {
                if (b2 == 12) {
                    return 0L;
                }
                if (b2 == 0) {
                    return this.f3875a.get();
                }
                if (b2 == 1) {
                    return this.f3875a.getShort();
                }
                if (b2 == 2) {
                    return this.f3875a.getInt();
                }
                if (b2 != 3) {
                    throw new Orion("type mismatch.");
                }
                return this.f3875a.getLong();
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return j;
    }

    public final float a(float f, int i, boolean z) {
        if (a(i)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 == 4) {
                return this.f3875a.getFloat();
            }
            if (b2 != 11) {
                if (b2 == 12) {
                    return 0.0f;
                }
                throw new Orion("type mismatch.");
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return f;
    }

    public final double a(double d, int i, boolean z) {
        if (a(i)) {
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 == 4) {
                return this.f3875a.getFloat();
            }
            if (b2 == 5) {
                return this.f3875a.getDouble();
            }
            if (b2 != 11) {
                if (b2 == 12) {
                    return 0.0d;
                }
                throw new Orion("type mismatch.");
            }
        } else if (z) {
            throw new Orion("require field not exist.");
        }
        return d;
    }

    public final HashMap a(Map map, int i, boolean z) {
        HashMap map2 = new HashMap();
        if (map != null && !map.isEmpty()) {
            Map.Entry entry = (Map.Entry) map.entrySet().iterator().next();
            Object key = entry.getKey();
            Object value = entry.getValue();
            if (a(i)) {
                ByteBuffer byteBuffer = this.f3875a;
                byte b = byteBuffer.get();
                byte b2 = (byte) (b & 15);
                if (((b & 240) >> 4) == 15) {
                    byteBuffer.get();
                }
                if (b2 == 8) {
                    int iA = a(0, 0, true);
                    if (iA < 0) {
                        throw new Orion("size invalid: " + iA);
                    }
                    for (int i2 = 0; i2 < iA; i2++) {
                        map2.put(a(key, 0, true), a(value, 1, true));
                    }
                } else if (b2 != 11) {
                    throw new Orion("type mismatch.");
                }
            } else if (z) {
                throw new Orion("require field not exist.");
            }
            return map2;
        }
        return new HashMap();
    }

    public final byte[] a(int i, boolean z) {
        if (!a(i)) {
            if (z) {
                throw new Orion("require field not exist.");
            }
            return null;
        }
        ByteBuffer byteBuffer = this.f3875a;
        byte b = byteBuffer.get();
        byte b2 = (byte) (b & 15);
        if (((b & 240) >> 4) == 15) {
            byteBuffer.get();
        }
        if (b2 == 9) {
            int iA = a(0, 0, true);
            if (iA >= 0) {
                byte[] bArr = new byte[iA];
                for (int i2 = 0; i2 < iA; i2++) {
                    bArr[i2] = a(bArr[0], 0, true);
                }
                return bArr;
            }
            throw new Orion("size invalid: " + iA);
        }
        if (b2 == 11) {
            return null;
        }
        if (b2 == 13) {
            ByteBuffer byteBuffer2 = this.f3875a;
            byte b3 = byteBuffer2.get();
            byte b4 = (byte) (b3 & 15);
            if (((b3 & 240) >> 4) == 15) {
                byteBuffer2.get();
            }
            if (b4 == 0) {
                int iA2 = a(0, 0, true);
                if (iA2 >= 0) {
                    byte[] bArr2 = new byte[iA2];
                    this.f3875a.get(bArr2);
                    return bArr2;
                }
                throw new Orion("invalid size, tag: " + i + ", type: " + ((int) b2) + ", " + ((int) b4) + ", size: " + iA2);
            }
            throw new Orion("type mismatch, tag: " + i + ", type: " + ((int) b2) + ", " + ((int) b4));
        }
        throw new Orion("type mismatch.");
    }

    public final Pyxis a(Pyxis pyxis, int i, boolean z) {
        if (!a(i)) {
            if (z) {
                throw new Orion("require field not exist.");
            }
            return null;
        }
        try {
            Pyxis pyxis2 = (Pyxis) pyxis.getClass().newInstance();
            ByteBuffer byteBuffer = this.f3875a;
            byte b = byteBuffer.get();
            byte b2 = (byte) (b & 15);
            if (((b & 240) >> 4) == 15) {
                byteBuffer.get();
            }
            if (b2 == 10) {
                pyxis2.a(this);
                while (this.f3875a.remaining() != 0) {
                    ByteBuffer byteBuffer2 = this.f3875a;
                    byte b3 = byteBuffer2.get();
                    byte b4 = (byte) (b3 & 15);
                    if (((b3 & 240) >> 4) == 15) {
                        byteBuffer2.get();
                    }
                    a(b4);
                    if (b4 == 11) {
                        break;
                    }
                }
                return pyxis2;
            }
            throw new Orion("type mismatch.");
        } catch (Exception e) {
            throw new Orion(e.getMessage());
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r11v2, types: [byte[], java.io.Serializable] */
    /* JADX WARN: Type inference failed for: r11v6, types: [java.io.Serializable, java.lang.Object[]] */
    /* JADX WARN: Type inference failed for: r12v12, types: [float[], java.io.Serializable] */
    /* JADX WARN: Type inference failed for: r12v17, types: [java.io.Serializable, long[]] */
    /* JADX WARN: Type inference failed for: r12v22, types: [int[], java.io.Serializable] */
    /* JADX WARN: Type inference failed for: r12v7, types: [double[], java.io.Serializable] */
    public final Serializable a(Object obj, int i, boolean z) {
        if (obj instanceof Byte) {
            return Byte.valueOf(a((byte) 0, i, z));
        }
        if (obj instanceof Boolean) {
            return Boolean.valueOf(a(false, i, z));
        }
        if (obj instanceof Short) {
            return Short.valueOf(a((short) 0, i, z));
        }
        if (obj instanceof Integer) {
            return Integer.valueOf(a(0, i, z));
        }
        if (obj instanceof Long) {
            return Long.valueOf(a(0L, i, z));
        }
        if (obj instanceof Float) {
            return Float.valueOf(a(0.0f, i, z));
        }
        if (obj instanceof Double) {
            return Double.valueOf(a(0.0d, i, z));
        }
        if (obj instanceof String) {
            return b(i, z);
        }
        if (obj instanceof Map) {
            return a((Map) obj, i, z);
        }
        if (obj instanceof List) {
            List list = (List) obj;
            if (list.isEmpty()) {
                return new ArrayList();
            }
            Object[] objArrB = b(list.get(0), i, z);
            if (objArrB == null) {
                return null;
            }
            ArrayList arrayList = new ArrayList();
            for (Object obj2 : objArrB) {
                arrayList.add(obj2);
            }
            return arrayList;
        }
        if (obj instanceof Pyxis) {
            return a((Pyxis) obj, i, z);
        }
        if (obj.getClass().isArray()) {
            if (!(obj instanceof byte[]) && !(obj instanceof Byte[])) {
                if (obj instanceof boolean[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer = this.f3875a;
                        byte b = byteBuffer.get();
                        byte b2 = (byte) (b & 15);
                        if (((b & 240) >> 4) == 15) {
                            byteBuffer.get();
                        }
                        if (b2 == 9) {
                            int iA = a(0, 0, true);
                            if (iA >= 0) {
                                boolean[] zArr = new boolean[iA];
                                for (int i2 = 0; i2 < iA; i2++) {
                                    zArr[i2] = a(zArr[0], 0, true);
                                }
                                return zArr;
                            }
                            throw new Orion("size invalid: " + iA);
                        }
                        if (b2 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                if (obj instanceof short[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer2 = this.f3875a;
                        byte b3 = byteBuffer2.get();
                        byte b4 = (byte) (b3 & 15);
                        if (((b3 & 240) >> 4) == 15) {
                            byteBuffer2.get();
                        }
                        if (b4 == 9) {
                            int iA2 = a(0, 0, true);
                            if (iA2 >= 0) {
                                short[] sArr = new short[iA2];
                                for (int i3 = 0; i3 < iA2; i3++) {
                                    sArr[i3] = a(sArr[0], 0, true);
                                }
                                return sArr;
                            }
                            throw new Orion("size invalid: " + iA2);
                        }
                        if (b4 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                if (obj instanceof int[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer3 = this.f3875a;
                        byte b5 = byteBuffer3.get();
                        byte b6 = (byte) (b5 & 15);
                        if (((b5 & 240) >> 4) == 15) {
                            byteBuffer3.get();
                        }
                        if (b6 == 9) {
                            int iA3 = a(0, 0, true);
                            if (iA3 >= 0) {
                                ?? r12 = new int[iA3];
                                for (int i4 = 0; i4 < iA3; i4++) {
                                    r12[i4] = a((int) r12[0], 0, true);
                                }
                                return r12;
                            }
                            throw new Orion("size invalid: " + iA3);
                        }
                        if (b6 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                if (obj instanceof long[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer4 = this.f3875a;
                        byte b7 = byteBuffer4.get();
                        byte b8 = (byte) (b7 & 15);
                        if (((b7 & 240) >> 4) == 15) {
                            byteBuffer4.get();
                        }
                        if (b8 == 9) {
                            int iA4 = a(0, 0, true);
                            if (iA4 >= 0) {
                                ?? r13 = new long[iA4];
                                for (int i5 = 0; i5 < iA4; i5++) {
                                    r13[i5] = a(r13[0], 0, true);
                                }
                                return r13;
                            }
                            throw new Orion("size invalid: " + iA4);
                        }
                        if (b8 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                if (obj instanceof float[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer5 = this.f3875a;
                        byte b9 = byteBuffer5.get();
                        byte b10 = (byte) (b9 & 15);
                        if (((b9 & 240) >> 4) == 15) {
                            byteBuffer5.get();
                        }
                        if (b10 == 9) {
                            int iA5 = a(0, 0, true);
                            if (iA5 >= 0) {
                                ?? r14 = new float[iA5];
                                for (int i6 = 0; i6 < iA5; i6++) {
                                    r14[i6] = a((float) r14[0], 0, true);
                                }
                                return r14;
                            }
                            throw new Orion("size invalid: " + iA5);
                        }
                        if (b10 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                if (obj instanceof double[]) {
                    if (a(i)) {
                        ByteBuffer byteBuffer6 = this.f3875a;
                        byte b11 = byteBuffer6.get();
                        byte b12 = (byte) (b11 & 15);
                        if (((b11 & 240) >> 4) == 15) {
                            byteBuffer6.get();
                        }
                        if (b12 == 9) {
                            int iA6 = a(0, 0, true);
                            if (iA6 >= 0) {
                                ?? r15 = new double[iA6];
                                for (int i7 = 0; i7 < iA6; i7++) {
                                    r15[i7] = a((double) r15[0], 0, true);
                                }
                                return r15;
                            }
                            throw new Orion("size invalid: " + iA6);
                        }
                        if (b12 != 11) {
                            throw new Orion("type mismatch.");
                        }
                    } else if (z) {
                        throw new Orion("require field not exist.");
                    }
                    return null;
                }
                Object[] objArr = (Object[]) obj;
                if (objArr.length != 0) {
                    return b(objArr[0], i, z);
                }
                throw new Orion("unable to get type of key and value.");
            }
            return a(i, z);
        }
        throw new Orion("read object error: unsupport type.");
    }

    public Perseus(byte[] bArr) {
        this.f3875a = ByteBuffer.wrap(bArr);
    }

    public Perseus(int i, byte[] bArr) {
        ByteBuffer byteBufferWrap = ByteBuffer.wrap(bArr);
        this.f3875a = byteBufferWrap;
        byteBufferWrap.position(4);
    }
}
