package com.onevcat.uniwebview;

import android.app.Activity;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import com.unity3d.player.UnityPlayer;
import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class A0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2816a;
    public final /* synthetic */ int b;
    public final /* synthetic */ int c;
    public final /* synthetic */ int d;
    public final /* synthetic */ int e;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public A0(String str, int i, int i2, int i3, int i4) {
        super(0);
        this.f2816a = str;
        this.b = i;
        this.c = i2;
        this.d = i3;
        this.e = i4;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        Activity activity = UnityPlayer.currentActivity;
        Intrinsics.checkNotNullExpressionValue(activity, "activity");
        String name = this.f2816a;
        N container = new N(activity, name, new C0636f(), null);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
        activity.addContentView(container.e, layoutParams);
        LinearLayout.LayoutParams layoutParams2 = new LinearLayout.LayoutParams(-1, -1, 1.0f);
        container.r.addView(container.q);
        container.r.addView(container.p, layoutParams2);
        container.e.addView(container.r, layoutParams);
        C0633e c0633e = C0633e.b;
        c0633e.getClass();
        Intrinsics.checkNotNullParameter(container, "container");
        Intrinsics.checkNotNullParameter(name, "name");
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.DEBUG, AbstractC0669q.a("Adding web view container to manager: ", name, c0654l, "message"));
        c0633e.f2889a.put(name, container);
        if (AbstractC0684v.e) {
            X frameLayout = container.e;
            Intrinsics.checkNotNullParameter(frameLayout, "frameLayout");
            Intrinsics.checkNotNullParameter(activity, "activity");
            container.o = new C0624b(frameLayout, activity);
        }
        container.a(this.b, this.c, this.d, this.e);
        return Unit.INSTANCE;
    }
}
