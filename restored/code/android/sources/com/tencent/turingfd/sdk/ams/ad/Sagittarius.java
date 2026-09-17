package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Sagittarius {
    public static byte[] a(Pyxis pyxis) {
        if (pyxis == null) {
            return null;
        }
        try {
            Phoenix phoenix = new Phoenix();
            phoenix.b = "UTF-8";
            pyxis.a(phoenix);
            byte[] bArr = new byte[phoenix.f3876a.position()];
            System.arraycopy(phoenix.f3876a.array(), 0, bArr, 0, phoenix.f3876a.position());
            return bArr;
        } catch (Exception unused) {
            return null;
        }
    }

    public static Pyxis a(byte[] bArr, Pyxis pyxis) {
        if (bArr != null && pyxis != null) {
            try {
                Perseus perseus = new Perseus(bArr);
                perseus.b = "UTF-8";
                pyxis.a(perseus);
                return pyxis;
            } catch (Exception unused) {
            }
        }
        return null;
    }
}
