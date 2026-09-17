package com.unity3d.player;

import android.content.Context;
import android.media.AudioManager;
import android.os.Handler;
import android.os.Looper;
import android.provider.Settings;
import com.bykv.vk.component.ttvideo.player.MediaFormat;

/* JADX INFO: renamed from: com.unity3d.player.q, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0733q {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f4062a;
    private final AudioManager b;
    private C0729o c;

    public C0733q(Context context) {
        this.f4062a = context;
        this.b = (AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO);
    }

    public final void a() {
        if (this.c != null) {
            this.f4062a.getContentResolver().unregisterContentObserver(this.c);
            this.c = null;
        }
    }

    public final void a(InterfaceC0731p interfaceC0731p) {
        this.c = new C0729o(new Handler(Looper.getMainLooper()), this.b, interfaceC0731p);
        this.f4062a.getContentResolver().registerContentObserver(Settings.System.CONTENT_URI, true, this.c);
    }
}
