package com.sigmob.sdk.base.services;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.IntentFilter;
import com.sigmob.sdk.base.utils.h;

/* JADX INFO: loaded from: classes3.dex */
public class d implements f.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    c f3246a;
    g b = g.STOP;

    public d() {
        if (this.f3246a == null) {
            this.f3246a = new c();
        }
    }

    public void a(Context context) {
        h.a(context, (BroadcastReceiver) this.f3246a, new IntentFilter("android.intent.action.DOWNLOAD_COMPLETE"), true);
    }

    public void b(Context context) {
        context.unregisterReceiver(this.f3246a);
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public boolean e() {
        a(com.sigmob.sdk.b.e());
        this.b = g.RUNNING;
        return false;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public g f() {
        return null;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public void g() {
        b(com.sigmob.sdk.b.e());
        this.b = g.STOP;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public Error h() {
        return null;
    }
}
