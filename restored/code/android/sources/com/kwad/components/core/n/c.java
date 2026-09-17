package com.kwad.components.core.n;

import android.os.Bundle;
import com.kwad.components.core.proxy.h;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.mvp.a;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c<T extends com.kwad.sdk.mvp.a> extends h {
    protected T abu;
    protected Presenter mPresenter;

    protected abstract T an();

    public abstract Presenter onCreatePresenter();

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onActivityCreated(Bundle bundle) {
        super.onActivityCreated(bundle);
        this.abu = (T) an();
        if (this.mPresenter == null) {
            Presenter presenterOnCreatePresenter = onCreatePresenter();
            this.mPresenter = presenterOnCreatePresenter;
            presenterOnCreatePresenter.N(this.ou);
        }
        this.mPresenter.q(this.abu);
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onDestroyView() {
        super.onDestroyView();
        T t = this.abu;
        if (t != null) {
            t.release();
        }
        onActivityDestroy();
    }

    protected void onActivityDestroy() {
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
        }
        this.ou = null;
    }
}
