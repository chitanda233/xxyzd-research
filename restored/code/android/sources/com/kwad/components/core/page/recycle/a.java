package com.kwad.components.core.page.recycle;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import com.kwad.components.core.proxy.h;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends h {
    private RecyclerView YT;
    private d aeS;

    protected abstract d a(RecyclerView recyclerView);

    private void uO() {
        RecyclerView recyclerViewFindViewById = findViewById(uS());
        this.YT = recyclerViewFindViewById;
        recyclerViewFindViewById.setItemAnimator((RecyclerView.ItemAnimator) null);
        this.YT.setLayoutManager(uR());
        this.aeS = a(this.YT);
    }

    private void uP() {
        this.YT.setAdapter(this.aeS);
    }

    public final RecyclerView uQ() {
        return this.YT;
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onActivityResult(int i, int i2, Intent intent) {
        super.onActivityResult(i, i2, intent);
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onViewCreated(View view, Bundle bundle) {
        super.onViewCreated(view, bundle);
        uO();
        uP();
    }

    private RecyclerView.LayoutManager uR() {
        return new LinearLayoutManager(this.mContext);
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onDestroyView() {
        super.onDestroyView();
        this.YT.clearOnChildAttachStateChangeListeners();
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onPause() {
        super.onPause();
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onResume() {
        super.onResume();
    }

    @Override // com.kwad.components.core.proxy.h, com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public void onDestroy() {
        super.onDestroy();
    }

    private static int uS() {
        return R.id.ksad_recycler_view;
    }
}
