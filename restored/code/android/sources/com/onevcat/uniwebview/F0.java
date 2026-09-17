package com.onevcat.uniwebview;

import android.webkit.WebSettings;
import com.unity3d.player.UnityPlayer;
import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class F0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final F0 f2829a = new F0();

    public F0() {
        super(0);
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        try {
            int i = C0687w.i;
            WebSettings.getDefaultUserAgent(UnityPlayer.currentActivity);
        } catch (Exception e) {
            C0654l c0654l = C0654l.b;
            String message = "Exception when preparing web view. This usually means there is no web view on the device and the whole UniWebView won't work. " + e.getMessage();
            c0654l.getClass();
            Intrinsics.checkNotNullParameter(message, "message");
            c0654l.a(EnumC0651k.CRITICAL, message);
        }
        return Unit.INSTANCE;
    }
}
