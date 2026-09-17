package com.kwad.components.core.widget;

import android.content.Context;
import android.content.DialogInterface;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.model.FeedType;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bx;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b<T extends AdResultData, R extends AdTemplate> extends KSFrameLayout implements DialogInterface.OnDismissListener, DialogInterface.OnShowListener, com.kwad.components.core.innerEc.a.g, com.kwad.sdk.core.j.c {
    public a avu;
    private long avv;
    private com.kwad.sdk.core.j.b dA;
    private com.kwad.components.core.widget.a.c fs;
    public AdInfo mAdInfo;
    protected T mAdResultData;
    public R mAdTemplate;
    public Context mContext;
    private bx mTimerHelper;
    protected boolean po;

    public interface a {
        void onAdClicked();

        void onAdShow();

        void onDislikeClicked();

        void onDownloadTipsDialogDismiss();

        void onDownloadTipsDialogShow();
    }

    public void bv() {
    }

    public void bw() {
    }

    protected abstract void by();

    public void cs() {
    }

    protected float getHWRatio() {
        return 0.0f;
    }

    protected abstract int getLayoutId();

    static /* synthetic */ long a(b bVar, long j) {
        long j2 = bVar.avv + j;
        bVar.avv = j2;
        return j2;
    }

    public b(Context context) {
        this(context, null);
    }

    public b(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public b(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mContext = context;
        initView();
    }

    public void setMargin(int i) {
        setPadding(i, i, i, i);
        if (com.kwad.sdk.core.config.e.KO()) {
            return;
        }
        setBackgroundColor(-1);
    }

    private void initView() {
        m.inflate(this.mContext, getLayoutId(), this);
        setRatio(getHWRatio());
        by();
        this.fs = new com.kwad.components.core.widget.a.c(this, 70);
    }

    public final boolean fv() {
        return (this.mAdInfo.status == 2 || this.mAdInfo.status == 3) ? false : true;
    }

    @Override // com.kwad.components.core.innerEc.a.g
    public final void dl() {
        bw();
    }

    @Override // com.kwad.components.core.innerEc.a.g
    public final void dm() {
        bv();
    }

    public void d(T t) {
        this.mAdResultData = t;
        R r = (R) com.kwad.sdk.core.response.helper.c.r(t);
        this.mAdTemplate = r;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(r);
        b(this);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public void af() {
        super.af();
        this.fs.An();
        this.fs.b(this);
        cs();
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public void ae() {
        super.ae();
        this.fs.a(this);
        this.fs.a(this.dA);
        this.fs.Am();
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public void onDismiss(DialogInterface dialogInterface) {
        a aVar = this.avu;
        if (aVar != null) {
            aVar.onDownloadTipsDialogDismiss();
        }
    }

    @Override // android.content.DialogInterface.OnShowListener
    public void onShow(DialogInterface dialogInterface) {
        a aVar = this.avu;
        if (aVar != null) {
            aVar.onDownloadTipsDialogShow();
        }
    }

    public void setInnerAdInteractionListener(a aVar) {
        this.avu = aVar;
    }

    public void setPageExitListener(com.kwad.sdk.core.j.b bVar) {
        this.dA = bVar;
    }

    public bx getTimerHelper() {
        if (this.mTimerHelper == null) {
            this.mTimerHelper = new bx();
        }
        return this.mTimerHelper;
    }

    public long getStayTime() {
        return this.avv + getTimerHelper().getTime();
    }

    private void b(ViewGroup viewGroup) {
        if (!com.kwad.sdk.core.config.e.Kr() && com.kwad.sdk.core.config.e.Kq() >= 0.0f) {
            e(viewGroup);
            com.kwad.components.core.widget.a aVar = new com.kwad.components.core.widget.a(viewGroup.getContext(), viewGroup);
            viewGroup.addView(aVar);
            aVar.setViewCallback(new com.kwad.components.core.widget.a.InterfaceC0474a() { // from class: com.kwad.components.core.widget.b.1
                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void ae() {
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void onWindowFocusChanged(boolean z) {
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void af() {
                    if (b.this.mAdTemplate.mPvReported && b.this.po) {
                        long jXp = b.this.getTimerHelper().Xp();
                        b.a(b.this, jXp);
                        com.kwad.sdk.core.adlog.c.a(b.this.mAdTemplate, jXp, (JSONObject) null);
                        b.this.po = false;
                    }
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void b(View view) {
                    if (!b.this.mAdTemplate.mPvReported && b.this.avu != null) {
                        b.this.po = true;
                        b.this.aa();
                        b.this.getTimerHelper().startTiming();
                    }
                    if (!b.this.po) {
                        b.this.getTimerHelper().startTiming();
                    }
                    b.this.po = true;
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void aA() {
                    if (b.this.mAdTemplate.mPvReported && b.this.po) {
                        long jXp = b.this.getTimerHelper().Xp();
                        b.a(b.this, jXp);
                        com.kwad.sdk.core.adlog.c.a(b.this.mAdTemplate, jXp, (JSONObject) null);
                        b.this.po = false;
                    }
                }
            });
            aVar.zY();
            return;
        }
        c cVarD = d(viewGroup);
        if (cVarD == null) {
            cVarD = new c(viewGroup.getContext(), viewGroup);
            viewGroup.addView(cVarD);
        }
        cVarD.setViewCallback(new c.a() { // from class: com.kwad.components.core.widget.b.2
            @Override // com.kwad.components.core.widget.c.a
            public final void fx() {
                b.this.aa();
            }
        });
        cVarD.setNeedCheckingShow(true);
    }

    private static c d(ViewGroup viewGroup) {
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt instanceof c) {
                return (c) childAt;
            }
        }
        return null;
    }

    public static void e(ViewGroup viewGroup) {
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt instanceof com.kwad.components.core.widget.a) {
                viewGroup.removeView(childAt);
            }
        }
    }

    protected void aa() {
        a aVar;
        if (!this.mAdTemplate.mPvReported && (aVar = this.avu) != null) {
            aVar.onAdShow();
        }
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        FeedType feedTypeFromInt = FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType);
        if (feedTypeFromInt == FeedType.FEED_TYPE_TEXT_NEW) {
            feedTypeFromInt = FeedType.FEED_TYPE_TEXT_BELOW;
        }
        c0502a.templateId = String.valueOf(feedTypeFromInt.getType());
        c0502a.aLj = String.valueOf(feedTypeFromInt.getFeedDefaultType() == null ? 0 : feedTypeFromInt.getFeedDefaultType().getDefaultType());
        bVar.b(c0502a);
        bVar.z(getHeight(), getWidth());
        com.kwad.components.core.t.b.wR().a(this.mAdTemplate, null, bVar);
    }

    public final void c(com.kwad.sdk.core.adlog.c.b bVar) {
        bVar.f(getTouchCoords());
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, bVar, (JSONObject) null);
        a aVar = this.avu;
        if (aVar != null) {
            aVar.onAdClicked();
        }
    }

    public final void zZ() {
        a aVar = this.avu;
        if (aVar != null) {
            aVar.onAdClicked();
        }
    }

    public final void bO(int i) {
        com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
        aVar.ne = i;
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        FeedType feedTypeFromInt = FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType);
        c0502a.templateId = String.valueOf(feedTypeFromInt.getType());
        c0502a.aLj = String.valueOf(feedTypeFromInt.getFeedDefaultType() == null ? 0 : feedTypeFromInt.getFeedDefaultType().getDefaultType());
        aVar.QR = c0502a;
        if (this.mAdTemplate.swipeAngle != 0) {
            aVar.aMR = this.mAdTemplate.swipeAngle;
        }
        if (getTouchCoords() != null) {
            aVar.ng = getTouchCoords();
        }
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, aVar, (JSONObject) null);
        a aVar2 = this.avu;
        if (aVar2 != null) {
            aVar2.onAdClicked();
        }
    }

    public final void Aa() {
        com.kwad.sdk.core.adlog.c.cj(this.mAdTemplate);
        a aVar = this.avu;
        if (aVar != null) {
            aVar.onDislikeClicked();
        }
    }
}
