package com.sigmob.sdk.splash;

import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ah;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.utils.v;
import java.util.HashSet;
import java.util.Iterator;

/* JADX INFO: loaded from: classes4.dex */
public class k implements ah {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3631a = "SplashViewAbilitySessionManager";
    private final HashSet<j> b;
    private BaseAdUnit c;

    public k() {
        HashSet<j> hashSet = new HashSet<>();
        this.b = hashSet;
        hashSet.add(new j());
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a() {
        if (this.c == null || com.sigmob.sdk.base.utils.f.a(this.b)) {
            SigmobLog.e("endDisplaySession() called adUnit is null.");
            return;
        }
        Iterator<j> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().b(this.c);
        }
        synchronized (this) {
            if (v.b(this.c)) {
                this.c.setSessionManager(null);
                this.c.destroy();
                this.c = null;
            }
        }
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(BaseAdUnit adUnit) {
        if (adUnit == null || com.sigmob.sdk.base.utils.f.a(this.b)) {
            SigmobLog.e("createDisplaySession() called adUnit is null.");
            return;
        }
        Iterator<j> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(adUnit);
        }
        this.c = adUnit;
        adUnit.setSessionManager(this);
    }

    @Override // com.sigmob.sdk.base.common.ah
    public void a(String event, int currentPosition) {
        SigmobLog.d("SplashViewAbilitySessionManager#recordDisplayEvent: event = " + event + ", currentPosition = " + currentPosition);
        if (this.c == null || com.sigmob.sdk.base.utils.f.a(this.b)) {
            SigmobLog.e("recordDisplayEvent() called adUnit is null.");
            return;
        }
        Iterator<j> it = this.b.iterator();
        while (it.hasNext()) {
            it.next().a(this.c, event, currentPosition);
        }
    }
}
