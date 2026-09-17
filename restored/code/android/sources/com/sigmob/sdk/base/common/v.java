package com.sigmob.sdk.base.common;

import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public class v implements ah {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3201a = "ExternalViewAbilitySessionManager";
    private final Set<u> b;
    private BaseAdUnit c;

    public v() {
        HashSet hashSet = new HashSet();
        this.b = hashSet;
        hashSet.add(new af());
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a() {
        SigmobLog.d("endDisplaySession() called");
        if (this.c == null) {
            SigmobLog.e("endDisplaySession() called mAdUnit is null");
            return;
        }
        Iterator<u> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().b(this.c);
        }
        this.c.setSessionManager(null);
        this.c.destroy();
        this.c = null;
    }

    public void a(int duration, int endTime) {
        if (this.c == null) {
            SigmobLog.e("onVideoPrepared() called mAdUnit is null");
            return;
        }
        Iterator<u> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(this.c, duration, endTime);
        }
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(BaseAdUnit adUnit) {
        if (adUnit == null) {
            SigmobLog.e("createDisplaySession() called adUnit is null");
            return;
        }
        this.c = adUnit;
        adUnit.setSessionManager(this);
        Iterator<u> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(adUnit);
        }
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(String event, int currentPosition) {
        SigmobLog.d("ExternalViewAbilitySessionManager#recordDisplayEvent: event = " + event + ", currentPosition = " + currentPosition);
        if (this.c == null) {
            SigmobLog.e("recordDisplayEvent() called mAdUnit is null");
            return;
        }
        Iterator<u> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(this.c, event, currentPosition);
        }
    }

    public void a(boolean isForceShow, int currentPosition) {
        if (this.c == null) {
            SigmobLog.e("onVideoShowSkip() called mAdUnit is null");
            return;
        }
        Iterator<u> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(this.c, isForceShow, currentPosition);
        }
    }
}
