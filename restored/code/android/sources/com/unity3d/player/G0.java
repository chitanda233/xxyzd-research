package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class G0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ int f3985a;
    final /* synthetic */ UnityPlayer b;

    G0(UnityPlayer unityPlayer, int i) {
        this.b = unityPlayer;
        this.f3985a = i;
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            UnityPlayer unityPlayer = this.b;
            AbstractC0705c.a(unityPlayer.mActivity, unityPlayer, this.f3985a);
        } catch (Exception e) {
            AbstractC0751z.Log(6, "Exception when opening Activity Indicator " + e);
        }
    }
}
