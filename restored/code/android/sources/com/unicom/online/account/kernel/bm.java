package com.unicom.online.account.kernel;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class bm implements Runnable {
    public final /* synthetic */ JSONObject b;
    public final /* synthetic */ bn c;

    public bm(bn bnVar, JSONObject jSONObject) {
        this.c = bnVar;
        this.b = jSONObject;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.c.e.onResult(this.b.toString());
    }
}
