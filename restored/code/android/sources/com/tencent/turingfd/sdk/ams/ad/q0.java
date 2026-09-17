package com.tencent.turingfd.sdk.ams.ad;

import java.io.Serializable;
import java.nio.ByteBuffer;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class q0 {
    public static HashMap d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Grape f3957a;
    public HashMap b;
    public final HashMap c;

    public q0() {
        Grape grape = new Grape();
        this.f3957a = grape;
        this.b = new HashMap();
        this.c = new HashMap();
        grape.f3853a = (short) 3;
        grape.d = 3;
    }

    public final Object a(Mango mango) throws Exception {
        if (!this.b.containsKey("resp")) {
            return null;
        }
        if (this.c.containsKey("resp")) {
            return this.c.get("resp");
        }
        byte[] bArr = (byte[]) this.b.get("resp");
        try {
            Perseus perseus = new Perseus();
            perseus.f3875a = ByteBuffer.wrap(bArr);
            perseus.b = "UTF-8";
            Serializable serializableA = perseus.a((Object) mango, 0, true);
            if (serializableA != null) {
                this.c.put("resp", serializableA);
            }
            return serializableA;
        } catch (Exception e) {
            throw new Exception(e);
        }
    }
}
