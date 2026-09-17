package com.sigmob.sdk.nativead;

import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ah;
import com.sigmob.sdk.base.models.BaseAdUnit;
import java.util.HashSet;
import java.util.Iterator;

/* JADX INFO: loaded from: classes4.dex */
public class i implements ah {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3576a = "NativeAdViewAbilitySessionManager";
    private final HashSet<h> b;
    private BaseAdUnit c = null;

    public i() {
        HashSet<h> hashSet = new HashSet<>();
        this.b = hashSet;
        hashSet.add(new h());
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a() {
        if (this.c == null) {
            SigmobLog.e("endDisplaySession() called mAdUnit is null");
            return;
        }
        Iterator<h> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().b(this.c);
        }
        this.c.setSessionManager(null);
        this.c.destroy();
        this.c = null;
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(BaseAdUnit adUnit) {
        if (adUnit == null) {
            SigmobLog.e("createDisplaySession() called mAdUnit is null");
            return;
        }
        Iterator<h> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(adUnit);
        }
        this.c = adUnit;
        adUnit.setSessionManager(this);
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(String event, int currentPosition) {
        SigmobLog.d("NativeAdViewAbilitySessionManager#recordDisplayEvent: event = " + event + ", currentPosition = " + currentPosition);
        if (this.c == null) {
            SigmobLog.e("createDisplaySession() called mAdUnit is null");
            return;
        }
        Iterator<h> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(this.c, event, currentPosition);
        }
    }
}
