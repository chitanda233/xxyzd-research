package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class o implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Context f3951a;
    public final /* synthetic */ HashMap b;

    public o(Context context, HashMap map) {
        this.f3951a = context;
        this.b = map;
    }

    @Override // java.lang.Runnable
    public final void run() {
        p.a(this.f3951a, this.b);
    }
}
