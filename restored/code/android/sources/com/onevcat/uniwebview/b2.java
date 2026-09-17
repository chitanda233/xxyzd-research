package com.onevcat.uniwebview;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import androidx.browser.customtabs.CustomTabsClient;
import androidx.browser.customtabs.CustomTabsIntent;
import androidx.browser.customtabs.CustomTabsService;
import androidx.browser.customtabs.CustomTabsSession;
import java.util.List;
import kotlin.collections.CollectionsKt;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes3.dex */
public final class b2 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Activity f2881a;
    public final String b;
    public final String c;
    public final c2 d;
    public CustomTabsClient e;
    public CustomTabsSession f;
    public Integer g;
    public boolean h;

    public b2(Activity activity, String name, String url, C0636f messageSender) {
        Intrinsics.checkNotNullParameter(activity, "activity");
        Intrinsics.checkNotNullParameter(name, "name");
        Intrinsics.checkNotNullParameter(url, "url");
        Intrinsics.checkNotNullParameter(messageSender, "messageSender");
        this.f2881a = activity;
        this.b = name;
        this.c = url;
        this.d = messageSender;
        C0663o c0663o = C0663o.b;
        c0663o.getClass();
        Intrinsics.checkNotNullParameter(this, "browsing");
        Intrinsics.checkNotNullParameter(name, "name");
        C0654l c0654l = C0654l.b;
        String strA = AbstractC0669q.a("Adding safe browsing to manager: ", name, c0654l, "message");
        EnumC0651k enumC0651k = EnumC0651k.DEBUG;
        c0654l.a(enumC0651k, strA);
        c0663o.f2917a.put(name, this);
        Intrinsics.checkNotNullParameter(activity, "activity");
        c0654l.getClass();
        Intrinsics.checkNotNullParameter("Checking CustomTabsService resolve info.", "message");
        c0654l.a(enumC0651k, "Checking CustomTabsService resolve info.");
        List<ResolveInfo> listQueryIntentServices = activity.getPackageManager().queryIntentServices(new Intent(CustomTabsService.ACTION_CUSTOM_TABS_CONNECTION), 0);
        Intrinsics.checkNotNullExpressionValue(listQueryIntentServices, "activity.packageManager.…ervices(serviceIntent, 0)");
        String message = "Resolved information: " + listQueryIntentServices;
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(enumC0651k, message);
        ResolveInfo resolveInfo = (ResolveInfo) CollectionsKt.firstOrNull((List) listQueryIntentServices);
        if (resolveInfo == null || CustomTabsClient.bindCustomTabsService(activity, resolveInfo.serviceInfo.packageName, new Z1(this))) {
            return;
        }
        Intrinsics.checkNotNullParameter("Custom Tabs didn't bind to a tab service. Something goes wrong. Trying to show the browser without a session.", "message");
        c0654l.a(EnumC0651k.CRITICAL, "Custom Tabs didn't bind to a tab service. Something goes wrong. Trying to show the browser without a session.");
        CustomTabsIntent.Builder builder = new CustomTabsIntent.Builder();
        Integer num = this.g;
        if (num != null) {
            builder.setToolbarColor(num.intValue());
        }
        builder.build().launchUrl(activity, Uri.parse(url));
    }
}
