package com.onevcat.uniwebview;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import androidx.browser.customtabs.CustomTabsIntent;
import com.sigmob.sdk.base.models.SigMacroCommon;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes3.dex */
public final class A implements InterfaceC0695y {
    public final Activity b;
    public final String c;
    public final String d;
    public final String e;
    public final c2 f;
    public String g;
    public UniWebViewProxyActivity h;
    public boolean i;
    public boolean j;

    public A(Activity activity, String name, String url, String callbackURLScheme, C0636f messageSender) {
        Intrinsics.checkNotNullParameter(activity, "activity");
        Intrinsics.checkNotNullParameter(name, "name");
        Intrinsics.checkNotNullParameter(url, "url");
        Intrinsics.checkNotNullParameter(callbackURLScheme, "callbackURLScheme");
        Intrinsics.checkNotNullParameter(messageSender, "messageSender");
        this.b = activity;
        this.c = name;
        this.d = url;
        this.e = callbackURLScheme;
        this.f = messageSender;
        C0630d c0630d = C0630d.b;
        c0630d.getClass();
        Intrinsics.checkNotNullParameter(this, "session");
        Intrinsics.checkNotNullParameter(name, "name");
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.DEBUG, AbstractC0669q.a("Adding auth session to manager: ", name, c0654l, "message"));
        c0630d.f2885a.put(name, this);
    }

    @Override // com.onevcat.uniwebview.InterfaceC0695y
    public final void a() {
        Activity activity = this.b;
        Intent intent = new Intent(activity, activity.getClass());
        intent.setFlags(603979776);
        this.b.startActivity(intent);
    }

    @Override // com.onevcat.uniwebview.InterfaceC0695y
    public final void b() {
        C0692x c0692x = InterfaceC0695y.f2943a;
        String id = this.g;
        if (id == null) {
            Intrinsics.throwUninitializedPropertyAccessException("handlerId");
            id = null;
        }
        c0692x.getClass();
        Intrinsics.checkNotNullParameter(id, "id");
        C0692x.b.remove(id);
        C0630d c0630d = C0630d.b;
        String name = this.c;
        c0630d.getClass();
        Intrinsics.checkNotNullParameter(name, "name");
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.DEBUG, AbstractC0669q.a("Removing auth session from manager: ", name, c0654l, "message"));
        c0630d.f2885a.remove(name);
        if (this.j) {
            return;
        }
        Intrinsics.checkNotNullParameter("Seems that user cancelled the auth task.", "message");
        c0654l.a(EnumC0651k.INFO, "Seems that user cancelled the auth task.");
        this.f.a(this.c, d2.AuthErrorReceived, new Y1("", SigMacroCommon.DEFAULT_XY, "user cancelled", null));
    }

    @Override // com.onevcat.uniwebview.InterfaceC0695y
    public final void a(UniWebViewProxyActivity activity, int i, int i2, Intent intent) {
        Intrinsics.checkNotNullParameter(activity, "activity");
        activity.finish();
    }

    @Override // com.onevcat.uniwebview.InterfaceC0695y
    public final void a(UniWebViewProxyActivity activity) {
        Intrinsics.checkNotNullParameter(activity, "activity");
        C0654l c0654l = C0654l.b;
        String message = "UniWebViewAuthenticationSession.onCreate. Proxy activity: " + activity;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        EnumC0651k enumC0651k = EnumC0651k.DEBUG;
        c0654l.a(enumC0651k, message);
        this.h = activity;
        Intrinsics.checkNotNullParameter("UniWebViewAuthenticationSession.startAuthSession. Trying to build custom tab intent...", "message");
        c0654l.a(enumC0651k, "UniWebViewAuthenticationSession.startAuthSession. Trying to build custom tab intent...");
        CustomTabsIntent customTabsIntentBuild = new CustomTabsIntent.Builder().build();
        if (this.i) {
            customTabsIntentBuild.intent.putExtra("com.google.android.apps.chrome.EXTRA_OPEN_NEW_INCOGNITO_TAB", true);
        }
        customTabsIntentBuild.intent.setData(Uri.parse(this.d));
        String message2 = "UniWebViewAuthenticationSession.startAuthSession. startActivityForResult, Tab Intent: " + customTabsIntentBuild + ", Internal Intent: " + customTabsIntentBuild.intent + ", Uri: " + customTabsIntentBuild.intent.getData();
        Intrinsics.checkNotNullParameter(message2, "message");
        c0654l.a(enumC0651k, message2);
        UniWebViewProxyActivity uniWebViewProxyActivity = this.h;
        if (uniWebViewProxyActivity == null) {
            Intrinsics.throwUninitializedPropertyAccessException("proxyActivity");
            uniWebViewProxyActivity = null;
        }
        uniWebViewProxyActivity.startActivityForResult(customTabsIntentBuild.intent, 12947761);
    }

    @Override // com.onevcat.uniwebview.InterfaceC0695y
    public final void a(Intent intent) {
        if (this.j) {
            C0654l c0654l = C0654l.b;
            String message = "An intent is already handled. Ignore this one..." + intent;
            c0654l.getClass();
            Intrinsics.checkNotNullParameter(message, "message");
            c0654l.a(EnumC0651k.CRITICAL, message);
            return;
        }
        this.j = true;
        if (intent == null) {
            C0654l c0654l2 = C0654l.b;
            c0654l2.getClass();
            Intrinsics.checkNotNullParameter("Auth session receives null intent.", "message");
            c0654l2.a(EnumC0651k.CRITICAL, "Auth session receives null intent.");
            this.f.a(this.c, d2.AuthErrorReceived, new Y1("", "1001", "null intent", null));
            return;
        }
        C0654l c0654l3 = C0654l.b;
        String message2 = "Auth session receives intent: " + intent + ". data: " + intent.getData();
        c0654l3.getClass();
        Intrinsics.checkNotNullParameter(message2, "message");
        EnumC0651k enumC0651k = EnumC0651k.INFO;
        c0654l3.a(enumC0651k, message2);
        Uri data = intent.getData();
        if (data == null) {
            return;
        }
        if (!Intrinsics.areEqual(this.e, "intent") && !Intrinsics.areEqual(data.getScheme(), this.e)) {
            String message3 = "Auth session receives uri " + data + ". But its scheme does not match the expected one: " + this.e;
            Intrinsics.checkNotNullParameter(message3, "message");
            c0654l3.a(EnumC0651k.CRITICAL, message3);
            this.f.a(this.c, d2.AuthErrorReceived, new Y1("", "1002", String.valueOf(data), null));
            return;
        }
        String message4 = "Auth session got result from service provider. " + intent.getDataString();
        Intrinsics.checkNotNullParameter(message4, "message");
        c0654l3.a(enumC0651k, message4);
        c2 c2Var = this.f;
        String str = this.c;
        d2 d2Var = d2.AuthFinished;
        String dataString = intent.getDataString();
        if (dataString == null) {
            dataString = String.valueOf(data);
        }
        Intrinsics.checkNotNullExpressionValue(dataString, "intent.dataString ?: \"$uri\"");
        c2Var.a(str, d2Var, dataString);
    }
}
