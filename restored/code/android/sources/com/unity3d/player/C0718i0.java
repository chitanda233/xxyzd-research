package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import android.content.res.TypedArray;
import android.widget.FrameLayout;

/* JADX INFO: renamed from: com.unity3d.player.i0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0718i0 extends FrameLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private C0711f f4047a;
    private UnityPlayer b;
    private K c;

    public C0718i0(Context context, UnityPlayer unityPlayer) {
        int i;
        super(context);
        this.c = new K(context);
        this.b = unityPlayer;
        C0711f c0711f = new C0711f(context, unityPlayer);
        this.f4047a = c0711f;
        c0711f.setId(context.getResources().getIdentifier("unitySurfaceView", "id", context.getPackageName()));
        if (a()) {
            this.f4047a.getHolder().setFormat(-3);
            this.f4047a.setZOrderOnTop(true);
            i = 0;
        } else {
            this.f4047a.getHolder().setFormat(-1);
            i = -16777216;
        }
        setBackgroundColor(i);
        this.f4047a.getHolder().addCallback(new SurfaceHolderCallbackC0716h0(this));
        this.f4047a.setFocusable(true);
        this.f4047a.setFocusableInTouchMode(true);
        this.f4047a.setContentDescription(a(context));
        addView(this.f4047a, new FrameLayout.LayoutParams(-1, -1, 17));
    }

    private static String a(Context context) {
        return context.getResources().getString(context.getResources().getIdentifier("game_view_content_description", "string", context.getPackageName()));
    }

    private static boolean a() {
        Activity activity = UnityPlayer.currentActivity;
        if (activity == null) {
            return false;
        }
        TypedArray typedArrayObtainStyledAttributes = activity.getTheme().obtainStyledAttributes(new int[]{android.R.attr.windowIsTranslucent});
        boolean z = typedArrayObtainStyledAttributes.getBoolean(0, false);
        typedArrayObtainStyledAttributes.recycle();
        return z;
    }

    final void a(float f) {
        this.f4047a.a(f);
    }

    public final void b() {
        K k = this.c;
        UnityPlayer unityPlayer = this.b;
        J j = k.b;
        if (j != null && j.getParent() != null) {
            unityPlayer.removeView(k.b);
        }
        this.c.b = null;
    }

    public final boolean c() {
        C0711f c0711f = this.f4047a;
        return c0711f != null && c0711f.a();
    }
}
