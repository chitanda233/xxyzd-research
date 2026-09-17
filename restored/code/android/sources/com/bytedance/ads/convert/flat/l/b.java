package com.bytedance.ads.convert.flat.l;

import android.os.Bundle;
import com.bytedance.ads.convert.flat.j.e;

/* JADX INFO: loaded from: classes2.dex */
public class b extends e.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile boolean f1731a = false;

    @Override // com.bytedance.ads.convert.flat.j.e
    public void a(int i, long j, boolean z, float f, double d, String str) {
    }

    @Override // com.bytedance.ads.convert.flat.j.e
    public void a(int i, Bundle bundle) {
        String str = "honor# OAIDLimitCallback handleResult retCode= " + i + " retInfo= " + bundle;
        if (i != 0 || bundle == null) {
            return;
        }
        this.f1731a = bundle.getBoolean("oa_id_limit_state");
        String str2 = "honor# OAIDLimitCallback handleResult success isLimit? " + this.f1731a;
    }
}
