package com.tencent.turingfd.sdk.ams.ad;

import android.util.Log;
import java.nio.ByteBuffer;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public abstract class r0 {
    public static Pyxis a(Mango mango, byte[] bArr) {
        if (bArr == null || bArr.length == 0) {
            Log.w("TuringDebug", "u1");
            return mango;
        }
        byte[] bArrA = Cstrictfp.a(bArr, Cstrictfp.a());
        if (bArrA == null || bArrA.length == 0) {
            Log.w("TuringDebug", "u2");
            return mango;
        }
        byte[] bArrB = Cprivate.b(bArrA);
        if (bArrB == null || bArrB.length == 0) {
            Log.w("TuringDebug", "u3");
            return mango;
        }
        q0 q0Var = new q0();
        if (bArrB.length < 4) {
            throw new IllegalArgumentException("decode package must include size head");
        }
        try {
            Perseus perseus = new Perseus(0, bArrB);
            perseus.b = "UTF-8";
            q0Var.f3957a.a(perseus);
            perseus.f3875a = ByteBuffer.wrap(q0Var.f3957a.g);
            if (q0.d == null) {
                HashMap map = new HashMap();
                q0.d = map;
                map.put("", new byte[0]);
            }
            q0Var.b = perseus.a((Map) q0.d, 0, false);
            try {
                return (Pyxis) q0Var.a(mango);
            } catch (Throwable th) {
                Log.w("TuringDebug", th);
                return mango;
            }
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}
