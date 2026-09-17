package com.onevcat.uniwebview;

import android.os.Bundle;
import androidx.browser.customtabs.CustomTabsCallback;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes3.dex */
public final class a2 extends CustomTabsCallback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ b2 f2877a;

    public a2(b2 b2Var) {
        this.f2877a = b2Var;
    }

    @Override // androidx.browser.customtabs.CustomTabsCallback
    public final void onNavigationEvent(int i, Bundle bundle) {
        C0654l c0654l = C0654l.b;
        String message = "onNavigationEvent: " + i;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(EnumC0651k.INFO, message);
        if (i == 6) {
            b2 b2Var = this.f2877a;
            b2Var.getClass();
            C0663o c0663o = C0663o.b;
            String name = b2Var.b;
            c0663o.getClass();
            Intrinsics.checkNotNullParameter(name, "name");
            String message2 = "Removing safe browsing from manager: " + name;
            Intrinsics.checkNotNullParameter(message2, "message");
            c0654l.a(EnumC0651k.DEBUG, message2);
            c0663o.f2917a.remove(name);
            b2 b2Var2 = this.f2877a;
            b2Var2.d.a(b2Var2.b, d2.SafeBrowsingFinished, "");
        }
    }
}
