package com.tencent.turingfd.sdk.ams.ad;

import androidx.core.view.MotionEventCompat;
import java.io.IOException;
import java.io.InputStream;
import java.text.DecimalFormat;
import java.util.HashMap;
import kotlin.UByte;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.continue, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Ccontinue {
    public static final String[] j = {"px", com.kuaishou.weapon.p0.t.q, "sp", "pt", "in", "mm"};

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Cabstract f3920a;
    public final HashMap b = new HashMap();
    public byte[] c;
    public String[] d;
    public int[] e;
    public int f;
    public int g;
    public int h;
    public int i;

    public final Document a(InputStream inputStream) throws IOException {
        String strB;
        String str;
        String strB2;
        byte[] bArr;
        Cabstract cabstract = new Cabstract();
        this.f3920a = cabstract;
        byte[] bArr2 = new byte[inputStream.available()];
        this.c = bArr2;
        inputStream.read(bArr2);
        inputStream.close();
        while (true) {
            int i = this.i;
            if (i >= this.c.length) {
                this.f3920a.getClass();
                return cabstract.b;
            }
            int iA = a(i);
            int i2 = -1;
            if (iA == -1) {
                this.f3920a.getClass();
            } else if (iA == 524291) {
                Cabstract cabstract2 = this.f3920a;
                Document documentNewDocument = cabstract2.c.newDocument();
                cabstract2.b = documentNewDocument;
                cabstract2.f3911a.push(documentNewDocument);
                this.i += 8;
            } else if (iA == 524672) {
                int iA2 = a(this.i + 4);
                int i3 = (iA2 / 4) - 2;
                this.h = i3;
                this.e = new int[i3];
                for (int i4 = 0; i4 < this.h; i4++) {
                    this.e[i4] = a(((i4 + 2) * 4) + this.i);
                }
                this.i += iA2;
            } else if (iA != 1835009) {
                switch (iA) {
                    case 1048832:
                        int iA3 = a(this.i + 16);
                        String strB3 = b(a(this.i + 20));
                        String strB4 = b(iA3);
                        this.f3920a.getClass();
                        this.b.put(strB3, strB4);
                        this.i += 24;
                        break;
                    case 1048833:
                        int iA4 = a(this.i + 16);
                        String strB5 = b(a(this.i + 20));
                        b(iA4);
                        this.f3920a.getClass();
                        this.b.remove(strB5);
                        this.i += 24;
                        break;
                    case 1048834:
                        int iA5 = a(this.i + 16);
                        int iA6 = a(this.i + 20);
                        int i5 = this.i;
                        byte[] bArr3 = this.c;
                        int i6 = (65280 & (bArr3[i5 + 29] << 8)) | (bArr3[i5 + 28] & 255);
                        String strB6 = b(iA6);
                        if (iA5 == -1) {
                            str = strB6;
                            strB = "";
                        } else {
                            strB = b(iA5);
                            str = this.b.containsKey(strB) ? ((String) this.b.get(strB)) + ':' + strB6 : strB6;
                        }
                        this.i += 36;
                        Cclass[] cclassArr = new Cclass[i6];
                        int i7 = 0;
                        while (i7 < i6) {
                            int iA7 = a(this.i);
                            int iA8 = a(this.i + 4);
                            int iA9 = a(this.i + 8);
                            int iA10 = a(this.i + 12);
                            int iA11 = a(this.i + 16);
                            Cclass cclass = new Cclass();
                            cclass.f3918a = b(iA8);
                            if (iA7 == i2) {
                                cclass.c = null;
                                cclass.b = null;
                            } else {
                                String strB7 = b(iA7);
                                if (this.b.containsKey(strB7)) {
                                    cclass.c = strB7;
                                    cclass.b = (String) this.b.get(strB7);
                                }
                            }
                            if (iA9 == i2) {
                                switch (iA10) {
                                    case 16777224:
                                        strB2 = String.format("@id/0x%08X", Integer.valueOf(iA11));
                                        break;
                                    case 33554440:
                                        strB2 = String.format("?id/0x%08X", Integer.valueOf(iA11));
                                        break;
                                    case 50331656:
                                        strB2 = b(iA11);
                                        break;
                                    case 67108872:
                                        strB2 = Float.toString(Float.intBitsToFloat(iA11));
                                        break;
                                    case 83886088:
                                        strB2 = Integer.toString(iA11 >> 8) + j[iA11 & 255];
                                        break;
                                    case 100663304:
                                        strB2 = new DecimalFormat("#.##%").format(((double) iA11) / 2.147483647E9d);
                                        break;
                                    case 268435464:
                                    case 285212680:
                                        strB2 = Integer.toString(iA11);
                                        break;
                                    case 301989896:
                                        strB2 = Boolean.toString(iA11 != 0);
                                        break;
                                    case 469762056:
                                    case 486539272:
                                        strB2 = String.format("#%08X", Integer.valueOf(iA11));
                                        break;
                                    default:
                                        strB2 = String.format("%08X/0x%08X", Integer.valueOf(iA10), Integer.valueOf(iA11));
                                        break;
                                }
                                cclass.d = strB2;
                            } else {
                                cclass.d = b(iA9);
                            }
                            cclassArr[i7] = cclass;
                            this.i += 20;
                            i7++;
                            i2 = -1;
                        }
                        Cabstract cabstract3 = this.f3920a;
                        cabstract3.getClass();
                        Element elementCreateElement = (strB == null || "".equals(strB)) ? cabstract3.b.createElement(strB6) : cabstract3.b.createElementNS(strB, str);
                        for (int i8 = 0; i8 < i6; i8++) {
                            Cclass cclass2 = cclassArr[i8];
                            String str2 = cclass2.c;
                            if (str2 == null || "".equals(str2)) {
                                elementCreateElement.setAttribute(cclass2.f3918a, cclass2.d);
                            } else {
                                elementCreateElement.setAttributeNS(cclass2.c, cclass2.b + ':' + cclass2.f3918a, cclass2.d);
                            }
                        }
                        ((Node) cabstract3.f3911a.peek()).appendChild(elementCreateElement);
                        cabstract3.f3911a.push(elementCreateElement);
                        break;
                    case 1048835:
                        int iA12 = a(this.i + 16);
                        b(a(this.i + 20));
                        if (iA12 != -1) {
                            b(iA12);
                        }
                        this.f3920a.f3911a.pop();
                        this.i += 24;
                        break;
                    case 1048836:
                        String strB8 = b(a(this.i + 16));
                        Cabstract cabstract4 = this.f3920a;
                        ((Node) cabstract4.f3911a.peek()).appendChild(cabstract4.b.createCDATASection(strB8));
                        this.i += 28;
                        break;
                    default:
                        this.i += 4;
                        break;
                }
            } else {
                int iA13 = a(this.i + 4);
                this.f = a(this.i + 8);
                this.g = a(this.i + 12);
                int i9 = this.i;
                int iA14 = a(i9 + 20) + i9;
                int iA15 = a(this.i + 24);
                this.d = new String[this.f];
                for (int i10 = 0; i10 < this.f; i10++) {
                    int iA16 = a(((i10 + 7) * 4) + this.i) + iA14;
                    String[] strArr = this.d;
                    byte[] bArr4 = this.c;
                    int i11 = bArr4[iA16 + 1];
                    int i12 = bArr4[iA16];
                    if (i11 == i12) {
                        bArr = new byte[i12];
                        for (int i13 = 0; i13 < i12; i13++) {
                            bArr[i13] = this.c[iA16 + 2 + i13];
                        }
                    } else {
                        int i14 = (i12 & 255) | ((i11 << 8) & MotionEventCompat.ACTION_POINTER_INDEX_MASK);
                        bArr = new byte[i14];
                        for (int i15 = 0; i15 < i14; i15++) {
                            bArr[i15] = this.c[(i15 * 2) + iA16 + 2];
                        }
                    }
                    strArr[i10] = new String(bArr);
                }
                if (iA15 > 0) {
                    for (int i16 = 0; i16 < this.g; i16++) {
                    }
                }
                this.i += iA13;
            }
        }
    }

    public final String b(int i) {
        if (i < 0 || i >= this.f) {
            return null;
        }
        return this.d[i];
    }

    public final int a(int i) {
        byte[] bArr = this.c;
        return (bArr[i] & UByte.MAX_VALUE) | ((bArr[i + 3] << 24) & (-16777216)) | ((bArr[i + 2] << 16) & 16711680) | ((bArr[i + 1] << 8) & MotionEventCompat.ACTION_POINTER_INDEX_MASK);
    }
}
