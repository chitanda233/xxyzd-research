package com.sigmob.sdk.nativead;

import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes4.dex */
public class u implements t {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final WeakReference<com.sigmob.sdk.videoplayer.f> f3587a;
    private l b;

    public u(com.sigmob.sdk.videoplayer.f adView) {
        this.f3587a = new WeakReference<>(adView);
    }

    private com.sigmob.sdk.videoplayer.f k() {
        return this.f3587a.get();
    }

    @Override // com.sigmob.sdk.nativead.t
    public void a() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.D();
    }

    public void a(int resId) {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.setHolderImageResource(resId);
    }

    @Override // com.sigmob.sdk.nativead.t
    public void a(l adVideoStatusListener) {
        this.b = adVideoStatusListener;
    }

    @Override // com.sigmob.sdk.nativead.t
    public void a(boolean isMute) {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.setSoundChange(isMute);
    }

    @Override // com.sigmob.sdk.nativead.t
    public void b() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.C();
    }

    @Override // com.sigmob.sdk.nativead.t
    public void c() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.C();
    }

    @Override // com.sigmob.sdk.nativead.t
    public void d() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.E();
    }

    @Override // com.sigmob.sdk.nativead.t
    public int e() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null || fVarK.getDuration() == 0) {
            return 0;
        }
        return (int) (fVarK.getDuration() / 1000);
    }

    @Override // com.sigmob.sdk.nativead.t
    public int f() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null || fVarK.getCurrentPositionWhenPlaying() == 0) {
            return 0;
        }
        return (int) ((fVarK.getCurrentPositionWhenPlaying() * 100) / fVarK.getDuration());
    }

    @Override // com.sigmob.sdk.nativead.t
    public l g() {
        return this.b;
    }

    @Override // com.sigmob.sdk.nativead.t
    public void h() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return;
        }
        fVarK.d();
    }

    @Override // com.sigmob.sdk.nativead.t
    public void i() {
        com.sigmob.sdk.videoplayer.f fVar = this.f3587a.get();
        if (fVar != null) {
            fVar.a();
        }
        this.f3587a.clear();
        this.b = null;
    }

    @Override // com.sigmob.sdk.nativead.t
    public int j() {
        com.sigmob.sdk.videoplayer.f fVarK = k();
        if (fVarK == null) {
            return 0;
        }
        return (int) (fVarK.getCurrentPositionWhenPlaying() / 1000);
    }
}
