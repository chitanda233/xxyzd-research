package com.kwad.components.core.proxy;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.view.WindowManager;
import com.kwad.sdk.o;

/* JADX INFO: loaded from: classes3.dex */
public abstract class g extends AlertDialog {
    protected ViewGroup DQ;
    public Activity mActivity;
    protected final Context mContext;

    protected ViewGroup dA() {
        return null;
    }

    protected float dz() {
        return -1.0f;
    }

    protected abstract void g(View view);

    protected abstract int getLayoutId();

    protected boolean pG() {
        return false;
    }

    protected boolean rt() {
        return true;
    }

    protected g(Activity activity) {
        super(activity);
        setOwnerActivity(activity);
        this.mActivity = activity;
        this.mContext = com.kwad.sdk.wrapper.m.wrapContextIfNeed(activity);
    }

    @Override // android.app.AlertDialog, android.app.Dialog
    protected final void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        try {
            if (getLayoutId() != 0) {
                this.DQ = (ViewGroup) com.kwad.sdk.wrapper.m.inflate(this.mContext, getLayoutId(), null);
            } else {
                this.DQ = dA();
            }
            setContentView(this.DQ);
            setCanceledOnTouchOutside(pG());
            getWindow().getDecorView().setPadding(0, 0, 0, 0);
            getWindow().setBackgroundDrawable(new ColorDrawable(0));
            getWindow().clearFlags(131072);
            WindowManager.LayoutParams attributes = getWindow().getAttributes();
            attributes.width = -1;
            attributes.height = -1;
            if (dz() != -1.0f) {
                attributes.dimAmount = dz();
            }
            getWindow().setAttributes(attributes);
            setCancelable(rt());
            g(this.DQ);
        } catch (Throwable th) {
            if (o.GE().FG()) {
                com.kwad.components.core.d.a.reportSdkCaughtException(th);
                dismiss();
                return;
            }
            throw th;
        }
    }

    @Override // android.app.Dialog
    public void setContentView(int i) {
        super.setContentView(i);
        this.DQ = (ViewGroup) com.kwad.sdk.wrapper.m.inflate(this.mContext, i, null);
    }

    @Override // android.app.Dialog
    public <T extends View> T findViewById(int i) {
        T t = (T) this.DQ.findViewById(i);
        return t != null ? t : (T) super.findViewById(i);
    }

    @Override // android.app.Dialog
    protected void onStart() {
        super.onStart();
        setTitle((CharSequence) null);
    }

    @Override // android.app.Dialog, android.content.DialogInterface
    public void dismiss() {
        Activity activity = this.mActivity;
        if (activity == null) {
            return;
        }
        try {
            com.kwad.sdk.wrapper.m.u(activity);
        } catch (Throwable unused) {
        }
        try {
            super.dismiss();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }
}
