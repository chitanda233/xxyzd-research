package com.onevcat.uniwebview;

import android.content.Context;
import android.content.Intent;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import androidx.core.net.MailTo;
import com.byazt.bv.BaseConstants;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.Locale;
import java.util.Set;
import kotlin.collections.CollectionsKt;
import kotlin.collections.SetsKt;
import kotlin.jvm.internal.Intrinsics;
import kotlin.text.StringsKt;

/* JADX INFO: renamed from: com.onevcat.uniwebview.r, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0672r {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Context f2924a;
    public final InterfaceC0675s b;
    public final C0654l c;
    public final Set d;
    public boolean e;

    public C0672r(Context context, InterfaceC0675s delegate) {
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f2924a = context;
        this.b = delegate;
        C0654l c0654l = C0654l.b;
        this.c = C0654l.b;
        this.d = SetsKt.mutableSetOf("uniwebview");
    }

    public final boolean a(String str, boolean z) {
        if (str == null || z || !this.e || ((C0687w) this.b).getHitTestResult().getType() == 0) {
            return false;
        }
        C0654l c0654l = this.c;
        c0654l.getClass();
        Intrinsics.checkNotNullParameter("UniWebView is opening links in external browser.", "message");
        c0654l.a(EnumC0651k.DEBUG, "UniWebView is opening links in external browser.");
        Intent intent = new Intent("android.intent.action.VIEW");
        intent.setData(Uri.parse(str));
        a(intent);
        return true;
    }

    /* JADX WARN: Code duplicated, block: B:101:0x02f1  */
    public final boolean a(String url, boolean z, String str) {
        Intent intent;
        Intent intent2;
        Intent intent3;
        Intent uri;
        Intent uri2;
        Intent intent4;
        List<ResolveInfo> listQueryIntentActivities;
        Intrinsics.checkNotNullParameter(url, "url");
        if (str != null) {
            U1 u1 = UniWebViewInterface.Companion;
            C c = new C(str, url);
            u1.getClass();
            E eA = U1.a(c);
            if (eA != null) {
                try {
                    if (!eA.b.getBoolean(com.alipay.sdk.m.y.o.c)) {
                        return true;
                    }
                } catch (Exception e) {
                    C0654l c0654l = C0654l.b;
                    String message = "Exception during parsing result for `ShouldUniWebViewHandleRequest`: " + e + ". Result from managed code: " + eA.f2825a;
                    c0654l.getClass();
                    Intrinsics.checkNotNullParameter(message, "message");
                    c0654l.a(EnumC0651k.CRITICAL, message);
                }
            }
        }
        Locale ROOT = Locale.ROOT;
        Intrinsics.checkNotNullExpressionValue(ROOT, "ROOT");
        String url2 = url.toLowerCase(ROOT);
        Intrinsics.checkNotNullExpressionValue(url2, "this as java.lang.String).toLowerCase(locale)");
        Intent intent5 = null;
        if (StringsKt.startsWith$default(url2, "file:", false, 2, (Object) null)) {
            C0687w c0687w = (C0687w) this.b;
            if (c0687w.getSettings().getAllowFileAccess()) {
                C0654l c0654l2 = C0654l.b;
                c0654l2.getClass();
                Intrinsics.checkNotNullParameter("Loading a local file. The local file loading will never be overridden.", "message");
                c0654l2.a(EnumC0651k.DEBUG, "Loading a local file. The local file loading will never be overridden.");
                return false;
            }
            C0654l c0654l3 = C0654l.b;
            c0654l3.getClass();
            Intrinsics.checkNotNullParameter("Local file loading is disabled. To enable loading from a `file://` URL, call `SetAllowFileAccess` with true.", "message");
            c0654l3.a(EnumC0651k.INFO, "Local file loading is disabled. To enable loading from a `file://` URL, call `SetAllowFileAccess` with true.");
            c0687w.c.a(c0687w.b, d2.PageErrorReceived, new Y1("", "-1", "Local file loading is disabled.", null));
            return true;
        }
        if (StringsKt.startsWith$default(url2, "uniwebviewinternal://", false, 2, (Object) null)) {
            if (StringsKt.contains$default((CharSequence) url2, (CharSequence) "__uniwebview_internal_video_end", false, 2, (Object) null)) {
                ((C0687w) this.b).d.onHideCustomView();
            }
            C0654l c0654l4 = this.c;
            c0654l4.getClass();
            Intrinsics.checkNotNullParameter("Url handled internally in UniWebView", "message");
            c0654l4.a(EnumC0651k.DEBUG, "Url handled internally in UniWebView");
            return true;
        }
        Intrinsics.checkNotNullParameter(url2, "url");
        C0654l c0654l5 = this.c;
        c0654l5.a(EnumC0651k.VERBOSE, AbstractC0669q.a("Checking url could match with a defined url scheme: ", url2, c0654l5, "message"));
        Set set = this.d;
        if (!(set instanceof Collection) || !set.isEmpty()) {
            Iterator it = set.iterator();
            while (it.hasNext()) {
                if (StringsKt.startsWith$default(url2, ((String) it.next()) + "://", false, 2, (Object) null)) {
                    C0654l c0654l6 = this.c;
                    c0654l6.a(EnumC0651k.VERBOSE, AbstractC0669q.a("Found url matching scheme: ", url2, c0654l6, "message"));
                    C0654l c0654l7 = this.c;
                    String message2 = "Url handled by defined scheme. Redirected to Unity. ".concat(url);
                    c0654l7.getClass();
                    Intrinsics.checkNotNullParameter(message2, "message");
                    c0654l7.a(EnumC0651k.DEBUG, message2);
                    C0687w c0687w2 = (C0687w) this.b;
                    c0687w2.getClass();
                    Intrinsics.checkNotNullParameter(url, "url");
                    c0687w2.c.a(c0687w2.b, d2.MessageReceived, url);
                    return true;
                }
            }
        }
        C0654l c0654l8 = this.c;
        c0654l8.a(EnumC0651k.VERBOSE, AbstractC0669q.a("Did not find a matched scheme for: ", url2, c0654l8, "message"));
        if (StringsKt.startsWith$default(url2, "sms:", false, 2, (Object) null)) {
            C0654l c0654l9 = this.c;
            c0654l9.getClass();
            Intrinsics.checkNotNullParameter("Received sms url...", "message");
            c0654l9.a(EnumC0651k.DEBUG, "Received sms url...");
            intent = new Intent("android.intent.action.VIEW", Uri.parse(url));
            intent.addCategory("android.intent.category.DEFAULT");
            intent.addCategory("android.intent.category.BROWSABLE");
        } else {
            intent = null;
        }
        if (!a(intent)) {
            if (StringsKt.startsWith$default(url2, "tel:", false, 2, (Object) null)) {
                C0654l c0654l10 = this.c;
                c0654l10.getClass();
                Intrinsics.checkNotNullParameter("Received tel url...", "message");
                c0654l10.a(EnumC0651k.DEBUG, "Received tel url...");
                intent2 = new Intent("android.intent.action.DIAL", Uri.parse(url));
            } else {
                intent2 = null;
            }
            if (!a(intent2)) {
                if (StringsKt.startsWith$default(url2, MailTo.MAILTO_SCHEME, false, 2, (Object) null)) {
                    C0654l c0654l11 = this.c;
                    c0654l11.getClass();
                    Intrinsics.checkNotNullParameter("Received mailto url...", "message");
                    c0654l11.a(EnumC0651k.DEBUG, "Received mailto url...");
                    intent3 = new Intent("android.intent.action.SENDTO", Uri.parse(url));
                } else {
                    intent3 = null;
                }
                if (!a(intent3)) {
                    if (StringsKt.startsWith$default(url2, "intent:", false, 2, (Object) null)) {
                        C0654l c0654l12 = this.c;
                        c0654l12.getClass();
                        Intrinsics.checkNotNullParameter("Received intent url...", "message");
                        c0654l12.a(EnumC0651k.DEBUG, "Received intent url...");
                        try {
                            uri = Intent.parseUri(url, 1);
                            if (this.f2924a.getPackageManager().resolveActivity(uri, 65536) == null) {
                                String str2 = uri.getPackage();
                                if (str2 == null) {
                                    uri = null;
                                } else {
                                    Intent intent6 = new Intent("android.intent.action.VIEW");
                                    intent6.setData(Uri.parse(BaseConstants.MARKET_PREFIX.concat(str2)));
                                    uri = intent6;
                                }
                            }
                        } catch (Exception e2) {
                            C0654l c0654l13 = this.c;
                            String message3 = "Parsing intent url error: " + e2 + ".message";
                            c0654l13.getClass();
                            Intrinsics.checkNotNullParameter(message3, "message");
                            c0654l13.a(EnumC0651k.CRITICAL, message3);
                        }
                    } else {
                        uri = null;
                    }
                    if (!a(uri)) {
                        if (StringsKt.startsWith$default(url2, "market:", false, 2, (Object) null)) {
                            C0654l c0654l14 = this.c;
                            c0654l14.getClass();
                            Intrinsics.checkNotNullParameter("Received market url...", "message");
                            c0654l14.a(EnumC0651k.DEBUG, "Received market url...");
                            try {
                                uri2 = Intent.parseUri(url, 1);
                            } catch (Exception e3) {
                                C0654l c0654l15 = this.c;
                                String message4 = "Parsing market url error. " + e3.getMessage();
                                c0654l15.getClass();
                                Intrinsics.checkNotNullParameter(message4, "message");
                                c0654l15.a(EnumC0651k.CRITICAL, message4);
                                uri2 = null;
                            }
                        } else {
                            uri2 = null;
                        }
                        if (!a(uri2)) {
                            if (a(url, z)) {
                                return true;
                            }
                            List listListOf = CollectionsKt.listOf((Object[]) new String[]{"http:", "https:", "file:", "about:blank"});
                            if ((listListOf instanceof Collection) && listListOf.isEmpty()) {
                                intent4 = new Intent("android.intent.action.VIEW", Uri.parse(url));
                                listQueryIntentActivities = this.f2924a.getPackageManager().queryIntentActivities(intent4, 0);
                                Intrinsics.checkNotNullExpressionValue(listQueryIntentActivities, "context.packageManager.q…tentActivities(intent, 0)");
                                if (!listQueryIntentActivities.isEmpty()) {
                                    intent5 = intent4;
                                }
                            } else {
                                Iterator it2 = listListOf.iterator();
                                while (true) {
                                    if (!it2.hasNext()) {
                                        intent4 = new Intent("android.intent.action.VIEW", Uri.parse(url));
                                        listQueryIntentActivities = this.f2924a.getPackageManager().queryIntentActivities(intent4, 0);
                                        Intrinsics.checkNotNullExpressionValue(listQueryIntentActivities, "context.packageManager.q…tentActivities(intent, 0)");
                                        if (!listQueryIntentActivities.isEmpty()) {
                                            intent5 = intent4;
                                        }
                                    } else if (StringsKt.startsWith$default(url2, (String) it2.next(), false, 2, (Object) null)) {
                                    }
                                }
                            }
                            if (a(intent5)) {
                                C0654l c0654l16 = this.c;
                                String message5 = "Url handled by a third party app: ".concat(url);
                                c0654l16.getClass();
                                Intrinsics.checkNotNullParameter(message5, "message");
                                c0654l16.a(EnumC0651k.DEBUG, message5);
                                return true;
                            }
                            C0654l c0654l17 = this.c;
                            String message6 = "Url is opening without overridden: ".concat(url);
                            c0654l17.getClass();
                            Intrinsics.checkNotNullParameter(message6, "message");
                            c0654l17.a(EnumC0651k.DEBUG, message6);
                            return false;
                        }
                    }
                }
            }
        }
        C0654l c0654l18 = this.c;
        c0654l18.getClass();
        Intrinsics.checkNotNullParameter("Url handled by intent.", "message");
        c0654l18.a(EnumC0651k.DEBUG, "Url handled by intent.");
        return true;
    }

    public final boolean a(Intent intent) {
        if (intent == null) {
            return false;
        }
        try {
            this.f2924a.startActivity(intent);
            return true;
        } catch (Exception unused) {
            C0654l c0654l = this.c;
            String message = "No Activity found to handle Intent: " + intent.getData();
            c0654l.getClass();
            Intrinsics.checkNotNullParameter(message, "message");
            c0654l.a(EnumC0651k.CRITICAL, message);
            return false;
        }
    }
}
