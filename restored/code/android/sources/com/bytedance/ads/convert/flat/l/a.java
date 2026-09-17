package com.bytedance.ads.convert.flat.l;

import android.os.Bundle;
import com.bytedance.ads.convert.flat.j.e;

/* JADX INFO: loaded from: classes2.dex */
public class a extends e.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile String f1730a = "";

    @Override // com.bytedance.ads.convert.flat.j.e
    public void a(int i, long j, boolean z, float f, double d, String str) {
    }

    @Override // com.bytedance.ads.convert.flat.j.e
    public void a(int i, Bundle bundle) {
        if (i != 0 || bundle == null) {
            return;
        }
        this.f1730a = bundle.getString("oa_id_flag");
    }
}
