package com.kwad.components.core.page.widget.a;

import android.app.Activity;
import android.app.Dialog;
import android.app.Fragment;
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
import com.kwad.components.core.t.q;
import com.kwad.components.core.t.w;
import com.kwad.sdk.R;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Objects;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b extends j implements DialogInterface.OnKeyListener {
    protected int agA;
    protected int agB;
    private boolean agC;
    private int agE;
    protected a agF;
    protected Fragment agG;
    protected View mRootView;
    protected boolean agy = false;
    protected boolean agz = true;
    protected boolean agD = true;
    private boolean agH = true;
    private int agI = -1;
    private float agJ = -1.0f;
    private final com.kwad.sdk.l.a.a mBackPressDelete = new com.kwad.sdk.l.a.a();
    private boolean agK = true;
    protected int agL = R.style.ksad_Theme_Dialog_Translucent;

    public interface a {
        Fragment vv();
    }

    public final b br(int i) {
        this.agE = i;
        return this;
    }

    @Override // android.content.DialogInterface.OnKeyListener
    public boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
        if (i == 4) {
            return this.mBackPressDelete.onBackPressed();
        }
        return false;
    }

    @Override // com.kwad.components.core.proxy.j
    public final View a(LayoutInflater layoutInflater, ViewGroup viewGroup) {
        a aVar = this.agF;
        if (aVar != null) {
            this.agG = aVar.vv();
            try {
                getChildFragmentManager().beginTransaction().replace(R.id.ksad_half_container_content_fragment, this.agG).commitAllowingStateLoss();
                getChildFragmentManager().executePendingTransactions();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
        if (this.mRootView == null) {
            this.mRootView = layoutInflater.inflate(getLayoutId(), viewGroup, true);
        }
        return this.mRootView;
    }

    @Override // android.app.DialogFragment
    public Dialog onCreateDialog(Bundle bundle) {
        Dialog dialogOnCreateDialog = super.onCreateDialog(bundle);
        dialogOnCreateDialog.setOnKeyListener(this);
        dialogOnCreateDialog.setCanceledOnTouchOutside(this.agK);
        if (vi() != 0) {
            setStyle(1, vi());
        }
        return dialogOnCreateDialog;
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public void onActivityCreated(Bundle bundle) {
        Dialog dialog = getDialog();
        b(dialog);
        Window window = dialog != null ? dialog.getWindow() : null;
        super.onActivityCreated(bundle);
        if (window != null) {
            window.setBackgroundDrawable(new ColorDrawable(0));
            if (this.agI < 0 && !Objects.equals(getTag(), "sensitive_words")) {
                this.agI = w.aQ(ServiceProvider.getContext().getApplicationContext()) ? -2 : -1;
            }
            window.setLayout(-1, this.agI);
            if (this.agJ > -1.0f) {
                WindowManager.LayoutParams attributes = window.getAttributes();
                attributes.dimAmount = this.agJ;
                window.setAttributes(attributes);
            }
        }
        if (dialog != null) {
            dialog.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.kwad.components.core.page.widget.a.b.1
                @Override // android.content.DialogInterface.OnKeyListener
                public final boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
                    if (!(b.this.agG instanceof DialogInterface.OnKeyListener)) {
                        return false;
                    }
                    ((DialogInterface.OnKeyListener) b.this.agG).onKey(dialogInterface, i, keyEvent);
                    return false;
                }
            });
        }
    }

    private boolean vp() {
        return this.agz;
    }

    private boolean vq() {
        return this.agy;
    }

    private void b(Dialog dialog) {
        int iK;
        Window window = dialog == null ? null : dialog.getWindow();
        if (window != null) {
            int i = -2;
            if (vp()) {
                iK = -2;
            } else {
                iK = this.agB;
                if (iK == 0) {
                    iK = com.kwad.sdk.c.a.a.k(getActivity());
                }
            }
            if (!vq() && (i = this.agA) == 0) {
                i = -1;
            }
            window.setLayout(i, iK);
            window.setGravity(17);
            if (!this.agD) {
                window.setBackgroundDrawable(new ColorDrawable(0));
                window.setDimAmount(0.0f);
            }
            boolean zVt = vt();
            int i2 = this.agE;
            if (i2 == 0) {
                if (vs()) {
                    window.setWindowAnimations(vr());
                }
            } else {
                window.setWindowAnimations(i2);
            }
            window.setGravity((this.agC && zVt) ? 21 : 81);
        }
    }

    private static int vr() {
        return R.style.ksad_Theme_Slide;
    }

    private boolean vs() {
        return this.agH;
    }

    private boolean vt() {
        Activity activity = getActivity();
        if (q.isInMultiWindowMode(activity)) {
            return q.e(activity);
        }
        Resources resources = ServiceProvider.getContext().getApplicationContext().getResources();
        return (resources == null || resources.getConfiguration() == null || resources.getConfiguration().orientation != 2) ? false : true;
    }

    protected int getLayoutId() {
        return R.layout.ksad_half_container_dialog_fragment;
    }

    public final void a(a aVar) {
        this.agF = aVar;
    }

    public final void bs(int i) {
        this.agI = i;
        vu();
    }

    public final void j(float f) {
        this.agJ = f;
    }

    private void vu() {
        Window window;
        Dialog dialog = getDialog();
        if (dialog == null || (window = dialog.getWindow()) == null) {
            return;
        }
        window.setLayout(-1, this.agI);
    }

    public final void setCanceledOnTouchOutside(boolean z) {
        this.agK = z;
        if (getDialog() != null) {
            getDialog().setCanceledOnTouchOutside(this.agK);
        }
    }

    protected int vi() {
        return this.agL;
    }
}
