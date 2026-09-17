package com.onevcat.uniwebview;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.ResolveInfo;
import androidx.browser.customtabs.CustomTabsService;
import com.unity3d.player.UnityPlayer;
import java.util.List;
import kotlin.collections.CollectionsKt;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class B0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final B0 f2818a = new B0();

    public B0() {
        super(0);
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        Activity activity = UnityPlayer.currentActivity;
        Intrinsics.checkNotNullExpressionValue(activity, "currentActivity");
        Intrinsics.checkNotNullParameter(activity, "activity");
        Intrinsics.checkNotNullParameter(activity, "activity");
        C0654l c0654l = C0654l.b;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter("Checking CustomTabsService resolve info.", "message");
        EnumC0651k enumC0651k = EnumC0651k.DEBUG;
        c0654l.a(enumC0651k, "Checking CustomTabsService resolve info.");
        List<ResolveInfo> listQueryIntentServices = activity.getPackageManager().queryIntentServices(new Intent(CustomTabsService.ACTION_CUSTOM_TABS_CONNECTION), 0);
        Intrinsics.checkNotNullExpressionValue(listQueryIntentServices, "activity.packageManager.…ervices(serviceIntent, 0)");
        String message = "Resolved information: " + listQueryIntentServices;
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(enumC0651k, message);
        return Boolean.valueOf(((ResolveInfo) CollectionsKt.firstOrNull((List) listQueryIntentServices)) != null);
    }
}
