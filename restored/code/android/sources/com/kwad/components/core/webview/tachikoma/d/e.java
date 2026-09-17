package com.kwad.components.core.webview.tachikoma.d;

import android.app.Activity;
import android.content.DialogInterface;
import android.content.res.Resources;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import com.kwad.components.core.proxy.j;
import com.kwad.components.core.webview.tachikoma.k;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.sdk.R;
import com.kwad.sdk.components.l;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public class e extends j {
    public String BV;
    private KSFrameLayout aii;
    public com.kwad.components.core.webview.tachikoma.f.c akN;
    protected StyleTemplate akP;
    protected com.kwad.components.core.webview.tachikoma.d.b auE;
    protected l auG;
    protected k auH;
    public boolean auI;
    public a auJ;
    private com.kwad.components.core.webview.tachikoma.f.e auM;
    private d auP;
    protected List<DialogInterface.OnDismissListener> auQ = new CopyOnWriteArrayList();
    public boolean auR = false;
    public AdResultData mAdResultData;
    private Presenter mPresenter;

    public interface a {
        boolean hm();
    }

    public static e b(b bVar) {
        e eVar = new e();
        eVar.mAdResultData = bVar.iF();
        eVar.BV = bVar.getTemplateId();
        eVar.auI = bVar.auI;
        eVar.auR = bVar.auR;
        eVar.akP = bVar.auT;
        eVar.auG = bVar.auG;
        eVar.auH = bVar.auU;
        Bundle bundle = new Bundle();
        bundle.putString("templateId", bVar.getTemplateId());
        eVar.setArguments(bundle);
        return eVar;
    }

    public final void a(com.kwad.components.core.webview.tachikoma.f.e eVar) {
        this.auM = eVar;
    }

    public final void d(DialogInterface.OnDismissListener onDismissListener) {
        if (onDismissListener != null) {
            this.auQ.add(onDismissListener);
        }
    }

    public final void e(DialogInterface.OnDismissListener onDismissListener) {
        this.auQ.remove(onDismissListener);
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        this.BV = getArguments().getString("templateId");
    }

    @Override // com.kwad.components.core.proxy.j
    public final View a(LayoutInflater layoutInflater, ViewGroup viewGroup) {
        if (this.aii == null) {
            this.aii = (KSFrameLayout) layoutInflater.inflate(R.layout.ksad_video_tk_dialog_layout, viewGroup, false);
        }
        return this.aii;
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public void onDestroyView() {
        try {
            super.onDestroyView();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.e("TkDialogFragment", "destroy view failed:" + th);
        }
        KSFrameLayout kSFrameLayout = this.aii;
        if (kSFrameLayout != null && (kSFrameLayout.getParent() instanceof ViewGroup)) {
            ((ViewGroup) this.aii.getParent()).removeView(this.aii);
            this.aii = null;
        }
        com.kwad.components.core.webview.tachikoma.f.e eVar = this.auM;
        if (eVar != null) {
            eVar.hs();
        }
    }

    @Override // android.app.Fragment
    public void onViewCreated(View view, Bundle bundle) {
        super.onViewCreated(view, bundle);
        G(view);
        com.kwad.components.core.webview.tachikoma.f.c cVar = this.akN;
        if (cVar != null) {
            cVar.hk();
        }
        com.kwad.components.core.webview.tachikoma.f.e eVar = this.auM;
        if (eVar != null) {
            eVar.hk();
        }
    }

    private void G(View view) {
        if (this.auE == null) {
            this.auE = kO();
        }
        kQ();
        if (this.mPresenter == null) {
            Presenter presenterBF = bF();
            this.mPresenter = presenterBF;
            presenterBF.N(view);
        }
        this.mPresenter.q(this.auE);
    }

    protected com.kwad.components.core.webview.tachikoma.d.b kO() {
        return new com.kwad.components.core.webview.tachikoma.d.b();
    }

    private Presenter bF() {
        this.mPresenter = new Presenter();
        if (this.auE.auH != null) {
            this.mPresenter.a(zK());
        } else {
            this.mPresenter.a(kP());
        }
        return this.mPresenter;
    }

    protected c kP() {
        return new c();
    }

    private d zK() {
        if (this.auP == null) {
            this.auP = new d();
        }
        return this.auP;
    }

    protected void kQ() {
        this.auE.a(this.mAdResultData);
        this.auE.mActivity = getActivity();
        this.auE.asz = this;
        this.auE.auF = this.aii;
        this.auE.BV = this.BV;
        this.auE.akP = this.akP;
        this.auE.auI = this.auI;
        this.auE.auG = this.auG;
        this.auE.auH = this.auH;
        this.auE.auJ = this.auJ;
        this.auE.akN = this.akN;
    }

    @Override // android.app.DialogFragment, android.content.DialogInterface.OnDismissListener
    public void onDismiss(DialogInterface dialogInterface) {
        super.onDismiss(dialogInterface);
        com.kwad.components.core.webview.tachikoma.f.c cVar = this.akN;
        if (cVar != null) {
            cVar.hs();
        }
        for (DialogInterface.OnDismissListener onDismissListener : this.auQ) {
            if (onDismissListener != null) {
                onDismissListener.onDismiss(dialogInterface);
            }
        }
        l lVar = this.auG;
        if (lVar != null) {
            lVar.callbackDialogDismiss();
        }
    }

    @Override // android.app.Fragment
    public void onDestroy() {
        super.onDestroy();
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
            this.mPresenter = null;
        }
        com.kwad.components.core.webview.tachikoma.d.b bVar = this.auE;
        if (bVar != null) {
            bVar.release();
            this.auE = null;
        }
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public void onActivityCreated(Bundle bundle) {
        Window window;
        Resources resources;
        int identifier;
        try {
            super.onActivityCreated(bundle);
        } catch (Throwable unused) {
        }
        if (getDialog() == null || (window = getDialog().getWindow()) == null) {
            return;
        }
        WindowManager.LayoutParams attributes = window.getAttributes();
        attributes.dimAmount = 0.0f;
        attributes.width = -1;
        attributes.height = -1;
        window.setAttributes(attributes);
        int dimensionPixelSize = 0;
        getDialog().setCanceledOnTouchOutside(false);
        window.getDecorView().setPadding(0, 0, 0, 0);
        window.setLayout(-1, -1);
        getDialog().getWindow().setBackgroundDrawable(new ColorDrawable(0));
        window.setSoftInputMode(16);
        if (f(getDialog().getOwnerActivity())) {
            window.setFlags(1024, 1024);
        }
        try {
            if (this.auG.isHideNavigationBar()) {
                if (getContext() != null && (resources = getContext().getResources()) != null && (identifier = resources.getIdentifier("navigation_bar_height", "dimen", "android")) > 0) {
                    dimensionPixelSize = getContext().getResources().getDimensionPixelSize(identifier);
                }
                if (dimensionPixelSize > 0) {
                    getDialog().getWindow().getDecorView().setSystemUiVisibility(5382);
                }
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        getDialog().setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.kwad.components.core.webview.tachikoma.d.e.1
            @Override // android.content.DialogInterface.OnKeyListener
            public final boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
                if (i != 4 || keyEvent.getAction() != 0) {
                    return false;
                }
                if (e.this.auR) {
                    return true;
                }
                if (e.this.auP != null) {
                    return e.this.auP.onBackPressed();
                }
                return false;
            }
        });
    }

    private static boolean f(Activity activity) {
        return activity != null && (activity.getWindow().getAttributes().flags & 1024) == 1024;
    }

    public static class b {
        private l auG;
        private boolean auI;
        private boolean auR;
        private StyleTemplate auT;
        private k auU;
        private AdResultData mAdResultData;
        private String templateId;

        public final AdResultData iF() {
            return this.mAdResultData;
        }

        public final void a(AdResultData adResultData) {
            this.mAdResultData = adResultData;
        }

        public final String getTemplateId() {
            return this.templateId;
        }

        public final void bN(String str) {
            this.templateId = str;
        }

        public final void a(StyleTemplate styleTemplate) {
            this.auT = styleTemplate;
        }

        public final void a(k kVar) {
            this.auU = kVar;
        }

        public final boolean lH() {
            return this.auI;
        }

        public final void bo(boolean z) {
            this.auI = false;
        }

        public final void bp(boolean z) {
            this.auR = true;
        }

        public final boolean zL() {
            return this.auR;
        }

        public final void c(l lVar) {
            this.auG = lVar;
        }
    }
}
