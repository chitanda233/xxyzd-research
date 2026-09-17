package com.kwad.components.core.page.widget.a;

import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.os.Handler;
import android.os.Parcelable;
import android.view.View;
import android.view.Window;
import android.widget.FrameLayout;
import com.kwad.components.core.t.l;
import com.kwad.components.core.t.v;
import com.kwad.sdk.R;
import com.kwad.sdk.core.view.RoundCornerNewLayout;
import com.kwad.sdk.lib.ad.desigin.KSCoordinatorLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private c ago;
    private ColorDrawable agq;
    private l.a ags;
    private Handler agt;
    private h agu;
    private e agp = new e();
    private int agr = 4;
    private String agv = null;

    @Override // com.kwad.components.core.page.widget.a.b
    protected final int vi() {
        return R.style.ksad_Theme_Dialog_Popup_ContainerTransparent;
    }

    public static a a(e eVar) {
        a aVar = new a();
        Bundle bundle = new Bundle();
        bundle.putParcelable("containerParams", eVar);
        aVar.setArguments(bundle);
        return aVar;
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public final void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        if (getArguments() != null) {
            Parcelable parcelable = getArguments().getParcelable("containerParams");
            if (parcelable instanceof e) {
                this.agp = (e) parcelable;
            }
            this.ago = this.agp.ahJ;
        }
        j(this.agp.ahC);
        if (this.agp.ahK != null) {
            this.agv = this.agp.ahK.get("merchantLaunchToken");
        }
    }

    @Override // android.app.Fragment
    public final void onViewCreated(View view, Bundle bundle) {
        super.onViewCreated(view, bundle);
    }

    @Override // com.kwad.components.core.page.widget.a.b, android.app.DialogFragment, android.app.Fragment
    public final void onActivityCreated(Bundle bundle) {
        vk();
        super.onActivityCreated(bundle);
        vl();
        vm();
        vj();
    }

    private void vj() {
        if (getDialog() == null) {
            return;
        }
        e eVar = this.agp;
        if (eVar == null || eVar.ahI) {
            getDialog().getWindow().setSoftInputMode(18);
            this.ags = new l.a() { // from class: com.kwad.components.core.page.widget.a.a.1
                @Override // com.kwad.components.core.t.l.a
                public final void bp(int i) {
                    a.this.bo(i);
                }

                @Override // com.kwad.components.core.t.l.a
                public final void vo() {
                    if (a.this.agt == null) {
                        a.this.agt = new Handler();
                    }
                    a.this.agt.postDelayed(new Runnable() { // from class: com.kwad.components.core.page.widget.a.a.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            a.this.bo(0);
                        }
                    }, 20L);
                }
            };
            l.a(getDialog().getWindow(), this.ags);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bo(int i) {
        View viewFindViewById;
        if (getView() == null || i < 0 || (viewFindViewById = getView().findViewById(R.id.ksad_half_bottom_container)) == null) {
            return;
        }
        viewFindViewById.setPadding(0, 0, 0, i);
    }

    private void vk() {
        if (this.agp.ahG) {
            return;
        }
        v.c(getDialog().getWindow());
    }

    private void vl() {
        if (!this.agp.ahG) {
            v.d(getDialog().getWindow());
        } else {
            getDialog().getWindow().clearFlags(2);
            getDialog().getWindow().setLayout(-1, -2);
        }
        if (this.agp.ahF) {
            return;
        }
        Window window = getDialog().getWindow();
        e eVar = this.agp;
        getContext();
        window.setLayout(-1, (int) eVar.vz());
    }

    private void vm() {
        if (getView() != null) {
            View viewFindViewById = getView().findViewById(R.id.ksad_container_coordinator_layout);
            viewFindViewById.setOnClickListener(new com.kwad.components.core.t.i() { // from class: com.kwad.components.core.page.widget.a.a.2
            });
            if (this.agp.ahF) {
                ColorDrawable colorDrawable = new ColorDrawable(Color.parseColor("#80000000"));
                this.agq = colorDrawable;
                colorDrawable.setAlpha(0);
                viewFindViewById.setBackground(this.agq);
                FrameLayout frameLayout = (FrameLayout) getView().findViewById(R.id.ksad_half_container_content_fragment);
                if (frameLayout != null) {
                    frameLayout.setBackgroundColor(0);
                    if (this.ago == null) {
                        this.ago = new c();
                    }
                    this.ago.aW(true);
                    this.ago.k(0.8f);
                    c cVar = this.ago;
                    e eVar = this.agp;
                    getContext();
                    cVar.bt((int) eVar.vz());
                    ((KSCoordinatorLayout.LayoutParams) frameLayout.getLayoutParams()).setBehavior(this.ago);
                    this.ago.a(new c.a() { // from class: com.kwad.components.core.page.widget.a.a.3
                        @Override // com.kwad.components.core.page.widget.a.c.a
                        public final void bq(int i) {
                            if (i == 5) {
                                a.this.dismissAllowingStateLoss();
                            }
                            if (a.this.agG instanceof h) {
                                a.this.vn();
                            }
                            if (a.this.agu != null && i != 1) {
                                h unused = a.this.agu;
                            }
                            if (i != 1) {
                                a.this.agr = i;
                            }
                        }

                        @Override // com.kwad.components.core.page.widget.a.c.a
                        public final void i(float f) {
                            if (a.this.agu != null) {
                                h unused = a.this.agu;
                            }
                            a.this.h(f);
                        }
                    });
                }
            }
            h(0.0f);
            setCanceledOnTouchOutside(!this.agp.ahE);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void vn() {
        if (((h) this.agG).vA()) {
            return;
        }
        int i = this.agr;
        if (i == 3 || i == 4) {
            this.ago.setState(i);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void h(float f) {
        if (getView() != null) {
            FrameLayout frameLayout = (FrameLayout) getView().findViewById(R.id.ksad_half_container_content_fragment);
            if (frameLayout instanceof RoundCornerNewLayout) {
                ((RoundCornerNewLayout) frameLayout).setTopRadius(f < 1.0f ? com.kwad.sdk.c.a.a.a(getView().getContext(), this.agp.ahD) : 0);
            }
        }
    }

    @Override // com.kwad.components.core.page.widget.a.b
    protected final int getLayoutId() {
        return R.layout.ksad_half_bottom_dialog_fragment;
    }

    @Override // android.app.Fragment
    public final void onDestroy() {
        Handler handler = this.agt;
        if (handler != null) {
            handler.removeCallbacksAndMessages(null);
            this.agt = null;
        }
        super.onDestroy();
    }

    @Override // com.kwad.components.core.proxy.j, android.app.DialogFragment
    public final void dismiss() {
        if (this.ags != null && getDialog() != null && getDialog().getWindow() != null) {
            l.b(getDialog().getWindow(), this.ags);
            this.ags = null;
        }
        dismissAllowingStateLoss();
    }
}
