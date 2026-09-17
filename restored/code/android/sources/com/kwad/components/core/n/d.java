package com.kwad.components.core.n;

import android.content.Context;
import android.util.AttributeSet;
import android.view.ViewGroup;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.mvp.a;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d<T extends com.kwad.sdk.mvp.a> extends KSFrameLayout {
    public T abu;
    public Presenter mPresenter;
    protected ViewGroup ou;

    protected abstract void a(ViewGroup viewGroup);

    protected boolean al() {
        return false;
    }

    protected abstract T an();

    protected abstract int getLayoutId();

    protected abstract void initData();

    public abstract Presenter onCreatePresenter();

    protected ViewGroup tC() {
        return null;
    }

    public d(Context context) {
        this(context, null);
    }

    private d(Context context, AttributeSet attributeSet) {
        this(context, null, 0);
    }

    private d(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, 0);
        com.kwad.sdk.core.d.c.w("jky", this + " BaseMVPView init createOnChild: " + al());
        if (al()) {
            return;
        }
        tB();
    }

    protected final void tB() {
        com.kwad.sdk.core.d.c.w("jky", this + " BaseMVPView createView");
        initData();
        if (getLayoutId() > 0) {
            this.ou = (ViewGroup) m.inflate(getContext(), getLayoutId(), this);
        } else {
            this.ou = tC();
        }
        a(this.ou);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public void ae() {
        super.ae();
        com.kwad.sdk.core.d.c.w("jky", this + " BaseMVPView onViewAttached");
        initMVP();
    }

    private void initMVP() {
        this.abu = (T) an();
        com.kwad.sdk.core.d.c.w("jky", this + " BaseMVPView initMVP mCallerContext: " + this.abu);
        if (this.mPresenter == null) {
            this.mPresenter = onCreatePresenter();
            com.kwad.sdk.core.d.c.w("jky", this + " BaseMVPView initMVP mPresenter: " + this.mPresenter + ", mContainerView: + " + this.ou);
            this.mPresenter.N(this.ou);
        }
        this.mPresenter.q(this.abu);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public void af() {
        super.af();
        T t = this.abu;
        if (t != null) {
            t.release();
        }
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
        }
    }
}
