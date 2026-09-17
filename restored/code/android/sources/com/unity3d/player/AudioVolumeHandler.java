package com.unity3d.player;

import android.content.Context;

/* JADX INFO: loaded from: classes4.dex */
public class AudioVolumeHandler implements InterfaceC0731p {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private C0733q f3976a;

    AudioVolumeHandler(Context context) {
        C0733q c0733q = new C0733q(context);
        this.f3976a = c0733q;
        c0733q.a(this);
    }

    public final void a() {
        this.f3976a.a();
        this.f3976a = null;
    }

    @Override // com.unity3d.player.InterfaceC0731p
    public final native void onAudioVolumeChanged(int i);
}
