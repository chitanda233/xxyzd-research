package com.kwad.components.core.e.c;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.content.res.Resources;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.core.proxy.g;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends g {
    private static b Qn;
    private final C0427b Qo;
    private com.kwad.components.core.e.c.a Qr;
    private boolean Qs;

    @Override // com.kwad.components.core.proxy.g
    public final int getLayoutId() {
        return 0;
    }

    @Override // com.kwad.components.core.proxy.g
    public final boolean pG() {
        return true;
    }

    public static boolean a(Context context, C0427b c0427b) {
        Activity activityFromContext;
        b bVar = Qn;
        if ((bVar == null || !bVar.isShowing()) && context != null && (activityFromContext = m.getActivityFromContext(context)) != null && !activityFromContext.isFinishing()) {
            com.kwad.sdk.a.a.c.Hx().dismiss();
            try {
                b bVar2 = new b(activityFromContext, c0427b);
                Qn = bVar2;
                bVar2.show();
                com.kwad.sdk.core.adlog.c.b(c0427b.adTemplate, 86, (JSONObject) null);
                return true;
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTrace(th);
            }
        }
        return false;
    }

    public static boolean pF() {
        b bVar = Qn;
        if (bVar != null) {
            return bVar.isShowing();
        }
        return false;
    }

    private b(Activity activity, C0427b c0427b) {
        super(activity);
        this.Qs = false;
        this.Qo = c0427b;
        if (com.kwad.sdk.c.a.a.f(activity)) {
            getWindow().addFlags(1024);
        }
        setOnShowListener(c0427b.Qu);
        setOnDismissListener(c0427b.Qv);
    }

    @Override // com.kwad.components.core.proxy.g
    public final ViewGroup dA() {
        com.kwad.components.core.e.c.a aVar = new com.kwad.components.core.e.c.a(this.mContext, this, this.Qo);
        this.Qr = aVar;
        return aVar;
    }

    @Override // com.kwad.components.core.proxy.g
    public final void g(View view) {
        this.Qr.setChangeListener(new com.kwad.components.core.e.c.a.InterfaceC0426a() { // from class: com.kwad.components.core.e.c.b.1
            @Override // com.kwad.components.core.e.c.a.InterfaceC0426a
            public final void pE() {
                b.this.dismiss();
            }
        });
    }

    @Override // com.kwad.components.core.proxy.g, android.app.Dialog
    public final void onStart() {
        super.onStart();
        b bVar = Qn;
        if (bVar != null) {
            bVar.setTitle((CharSequence) null);
        }
    }

    @Override // android.app.Dialog, android.view.Window.Callback
    public final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        Qn = null;
    }

    @Override // com.kwad.components.core.proxy.g, android.app.Dialog, android.content.DialogInterface
    public final void dismiss() {
        super.dismiss();
        Qn = null;
    }

    public final void an(boolean z) {
        this.Qs = z;
        dismiss();
    }

    public final boolean pH() {
        return this.Qs;
    }

    @Override // android.app.Dialog
    public final void show() {
        Resources resources;
        int identifier;
        try {
            super.show();
            try {
                if (((getContext() == null || (resources = getContext().getResources()) == null || (identifier = resources.getIdentifier("navigation_bar_height", "dimen", "android")) <= 0) ? 0 : getContext().getResources().getDimensionPixelSize(identifier)) > 0) {
                    getWindow().getDecorView().setSystemUiVisibility(5382);
                    return;
                }
                return;
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                return;
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
        com.kwad.sdk.core.d.c.printStackTraceOnly(e);
    }

    @Override // android.app.Dialog
    public final boolean isShowing() {
        return super.isShowing();
    }

    @Override // android.app.Dialog
    public final void onBackPressed() {
        super.onBackPressed();
        com.kwad.sdk.core.adlog.c.ct(this.Qo.adTemplate);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.e.c.b$b, reason: collision with other inner class name */
    public static class C0427b {
        protected DialogInterface.OnShowListener Qu;
        protected DialogInterface.OnDismissListener Qv;
        protected final AdTemplate adTemplate;
        protected String url;

        /* synthetic */ C0427b(a aVar, byte b) {
            this(aVar);
        }

        private C0427b(a aVar) {
            this.adTemplate = aVar.adTemplate;
            this.url = aVar.url;
            this.Qu = aVar.Qu;
            this.Qv = aVar.Qv;
        }
    }

    public static class a {
        private DialogInterface.OnShowListener Qu;
        private DialogInterface.OnDismissListener Qv;
        private AdTemplate adTemplate;
        private String url;

        public final a aD(AdTemplate adTemplate) {
            this.adTemplate = adTemplate;
            return this;
        }

        public final a am(String str) {
            this.url = str;
            return this;
        }

        public final a a(DialogInterface.OnShowListener onShowListener) {
            this.Qu = onShowListener;
            return this;
        }

        public final a c(DialogInterface.OnDismissListener onDismissListener) {
            this.Qv = onDismissListener;
            return this;
        }

        public final C0427b pI() {
            if (com.kwad.components.core.a.oV.booleanValue() && (this.adTemplate == null || TextUtils.isEmpty(this.url))) {
                throw new IllegalArgumentException("param is error, please check it");
            }
            return new C0427b(this, (byte) 0);
        }
    }
}
