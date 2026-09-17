package com.sigmob.sdk.base.common;

import android.content.Context;
import android.net.Uri;
import android.os.Handler;
import android.text.TextUtils;
import com.byazt.bv.BaseConstants;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.windad.WindAds;
import java.util.EnumSet;

/* JADX INFO: loaded from: classes3.dex */
public class ao {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final b f3157a = new b() { // from class: com.sigmob.sdk.base.common.ao.1
        @Override // com.sigmob.sdk.base.common.ao.b
        public void a(String url, an urlAction) {
        }

        @Override // com.sigmob.sdk.base.common.ao.b
        public void b(String url, an lastFailedUrlAction) {
        }
    };
    private static final c b = new c() { // from class: com.sigmob.sdk.base.common.ao.2
        @Override // com.sigmob.sdk.base.common.ao.c
        public void a() {
        }

        @Override // com.sigmob.sdk.base.common.ao.c
        public void b() {
        }

        @Override // com.sigmob.sdk.base.common.ao.c
        public void c() {
        }
    };
    private final EnumSet<an> c;
    private final b d;
    private final b e;
    private final c f;
    private final BaseAdUnit g;
    private final boolean h;
    private boolean i;
    private boolean j;
    private boolean k;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.common.ao$3, reason: invalid class name */
    class AnonymousClass3 implements ap.a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ an f3158a;
        final /* synthetic */ Context b;
        final /* synthetic */ ao c;
        final /* synthetic */ Uri d;
        final /* synthetic */ String e;

        AnonymousClass3(final an val$followDeepLink, final Context val$context, final ao val$finalUrlHandler, final Uri val$deeplinkUri, final String val$finalHandleUrL) {
            this.f3158a = val$followDeepLink;
            this.b = val$context;
            this.c = val$finalUrlHandler;
            this.d = val$deeplinkUri;
            this.e = val$finalHandleUrL;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(String str, an anVar) {
            try {
                ao.this.d.b(str, anVar);
            } catch (Throwable unused) {
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(String str, an anVar) {
            try {
                ao.this.d.a(str, anVar);
            } catch (Throwable unused) {
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void c(String str, an anVar) {
            try {
                ao.this.d.b(str, anVar);
            } catch (Throwable unused) {
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void d(String str, an anVar) {
            try {
                ao.this.d.a(str, anVar);
            } catch (Throwable unused) {
            }
        }

        @Override // com.sigmob.sdk.base.common.ap.a
        public void a(final String resolvedUrl) {
            final an anVar = this.f3158a;
            if (!resolvedUrl.toLowerCase().startsWith("http")) {
                anVar = an.FOLLOW_DEEP_LINK;
            }
            try {
                anVar.a(this.b, Uri.parse(resolvedUrl), this.c, ao.this.g);
                WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.base.common.ao$3$$ExternalSyntheticLambda0
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.d(resolvedUrl, anVar);
                    }
                });
            } catch (Exception unused) {
                WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.base.common.ao$3$$ExternalSyntheticLambda1
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.c(resolvedUrl, anVar);
                    }
                });
            }
        }

        @Override // com.sigmob.sdk.base.common.ap.a
        public void a(String message, Throwable throwable) {
            try {
                this.f3158a.a(this.b, this.d, this.c, ao.this.g);
                Handler handler = WindAds.sharedAds().getHandler();
                final String str = this.e;
                final an anVar = this.f3158a;
                handler.post(new Runnable() { // from class: com.sigmob.sdk.base.common.ao$3$$ExternalSyntheticLambda2
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.b(str, anVar);
                    }
                });
            } catch (Exception unused) {
                Handler handler2 = WindAds.sharedAds().getHandler();
                final String str2 = this.e;
                final an anVar2 = this.f3158a;
                handler2.post(new Runnable() { // from class: com.sigmob.sdk.base.common.ao$3$$ExternalSyntheticLambda3
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.a(str2, anVar2);
                    }
                });
            }
        }
    }

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private EnumSet<an> f3160a = EnumSet.of(an.NOOP);
        private b b = ao.f3157a;
        private b c = ao.f3157a;
        private c d = ao.b;
        private boolean e = false;
        private boolean f = false;
        private BaseAdUnit g;

        public a a(an first, an... others) {
            this.f3160a = EnumSet.of(first, others);
            return this;
        }

        public a a(b resultActions) {
            this.b = resultActions;
            return this;
        }

        public a a(c sigmobSchemeListener) {
            this.d = sigmobSchemeListener;
            return this;
        }

        public a a(BaseAdUnit adunit) {
            this.g = adunit;
            return this;
        }

        public a a(boolean skip) {
            this.e = skip;
            return this;
        }

        public ao a() {
            return new ao(this.f3160a, this.b, this.c, this.d, this.e, this.g, this.f);
        }

        public a b(b resultActions) {
            this.c = resultActions;
            return this;
        }

        public a b(boolean enable) {
            this.f = enable;
            return this;
        }
    }

    public interface b {
        void a(String url, an urlAction);

        void b(String url, an lastFailedUrlAction);
    }

    public interface c {
        void a();

        void b();

        void c();
    }

    private ao(EnumSet<an> supportedUrlActions, b resultActions, b deepLinkResultActions, c sigmobSchemeListener, boolean skipShowSigmobBrowser, BaseAdUnit adUnit, boolean withoOutresolvedUrl) {
        this.c = EnumSet.copyOf((EnumSet) supportedUrlActions);
        this.d = resultActions;
        this.e = deepLinkResultActions;
        this.f = sigmobSchemeListener;
        this.h = skipShowSigmobBrowser;
        this.g = adUnit;
        this.i = false;
        this.j = false;
        this.k = withoOutresolvedUrl;
    }

    private void a(String url, an urlAction, String message, Throwable throwable) {
        Preconditions.NoThrow.checkNotNull(message);
        if (urlAction == null) {
            urlAction = an.NOOP;
        }
        SigmobLog.d(message, throwable);
        this.d.b(url, urlAction);
    }

    public void a(Context context, String url) {
        Preconditions.NoThrow.checkNotNull(context);
        b(context, url);
    }

    boolean a() {
        return this.h;
    }

    public boolean b(Context context, String url) {
        an anVar = an.NOOP;
        final String strMacroProcess = null;
        for (final an anVar2 : this.c) {
            String strA = anVar2.a(this.g);
            int interactionType = this.g.getInteractionType();
            if (!TextUtils.isEmpty(url) && interactionType != 7) {
                strA = url;
            }
            if (!TextUtils.isEmpty(strA)) {
                strMacroProcess = this.g.getMacroCommon().macroProcess(strA);
                try {
                    Uri uri = Uri.parse(strMacroProcess);
                    AndroidMarket androidMarket = this.g.getAndroidMarket();
                    if (anVar2 != an.FOLLOW_DEEP_LINK || !uri.getScheme().equalsIgnoreCase(BaseConstants.SCHEME_MARKET) || androidMarket == null || TextUtils.isEmpty(androidMarket.market_url)) {
                        if (anVar2.a(uri, interactionType)) {
                            if (!this.k && an.OPEN_WITH_BROWSER == anVar2) {
                                ap.a(strMacroProcess, new AnonymousClass3(anVar2, context, this, uri, strMacroProcess));
                                return true;
                            }
                            anVar2.a(context, uri, this, this.g);
                            WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.base.common.ao.4
                                @Override // java.lang.Runnable
                                public void run() {
                                    ao.this.d.a(strMacroProcess, anVar2);
                                }
                            });
                            return true;
                        }
                    }
                } catch (Throwable unused) {
                    this.d.b(strMacroProcess, anVar2);
                }
            }
        }
        try {
            a(strMacroProcess, anVar, "Link ignored. Unable to handle url: ", null);
            return false;
        } catch (Throwable th) {
            SigmobLog.e("handleResolvedUrl error", th);
            return false;
        }
    }
}
