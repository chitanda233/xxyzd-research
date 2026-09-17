package com.sigmob.sdk.nativead;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.view.ViewTreeObserver;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.common.utils.TouchLocation;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.common.ah;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.SigImage;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.SigVideo;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.NativeADEventListener;
import com.sigmob.windad.natives.WindNativeAdData;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Stack;

/* JADX INFO: loaded from: classes4.dex */
public class ab implements View.OnClickListener, View.OnTouchListener, a, ac, g, WindNativeAdData.DislikeInteractionCallback {
    private static final Stack<x> M = new Stack<>();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3562a = "ab";
    private static final int e = 1;
    private static final int f = 2;
    private static final int g = 3;
    private static final int h = 4;
    private boolean A;
    private boolean D;
    private boolean E;
    private List<View> F;
    private long G;
    private WindNativeAdData.DislikeInteractionCallback J;
    private boolean K;
    private x L;
    protected WindNativeAdData b;
    protected BaseAdUnit c;
    protected k d;
    private WindAdMetaData i;
    private r j;
    private p k;
    private f n;
    private n o;
    private MotionEvent p;
    private e q;
    private NativeADEventListener r;
    private boolean s;
    private ViewGroup t;
    private ViewGroup.LayoutParams u;
    private Bitmap v;
    private com.sigmob.sdk.base.views.q w;
    private boolean x;
    private v y;
    private boolean z;
    private List<View> l = new ArrayList();
    private final HashSet<View> m = new HashSet<>();
    private boolean B = true;
    private boolean C = false;
    private List<View> H = new ArrayList();
    private final List<View> I = new ArrayList();
    private com.sigmob.sdk.base.views.q.b N = new com.sigmob.sdk.base.views.q.b() { // from class: com.sigmob.sdk.nativead.ab.5
        @Override // com.sigmob.sdk.base.views.q.b
        public void a() {
            if (ab.this.w != null) {
                ab.this.w.dismiss();
                ab.this.w.c();
                ab.this.w = null;
            }
            ab.this.x = false;
            ab.this.c.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_PREVIEW;
            ab.this.j().a(com.sigmob.sdk.base.common.a.g, 0);
        }

        @Override // com.sigmob.sdk.base.views.q.b
        public void a(Error error) {
        }

        @Override // com.sigmob.sdk.base.views.q.b
        public void a(String url, String clickCoordinate) {
            if (ab.this.c == null) {
                return;
            }
            ab.this.c.getClickCommon().sld = "0";
            ab.this.c.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
            ab.this.c.getClickCommon().click_scene = "appinfo";
            ab.this.c.getClickCommon().is_final_click = true;
            if (ab.this.x) {
                ab.this.y().a(com.sigmob.sdk.base.a.PREVIEW, url, clickCoordinate, true);
            }
        }

        @Override // com.sigmob.sdk.base.views.q.b
        public void b() {
            if (ab.this.j != null) {
                ab.this.r().a();
            }
            ab.this.j().a(com.sigmob.sdk.base.common.a.f, 0);
        }
    };

    /* JADX INFO: Access modifiers changed from: private */
    public Context N() {
        return com.sigmob.sdk.b.e();
    }

    private void O() {
        try {
            Activity activityD = com.sigmob.sdk.base.utils.w.d(P());
            if (this.w == null && activityD != null) {
                com.sigmob.sdk.base.views.q qVar = new com.sigmob.sdk.base.views.q(activityD, this.c);
                this.w = qVar;
                qVar.a(this.N);
            }
            com.sigmob.sdk.base.views.q qVar2 = this.w;
            if (qVar2 == null || !qVar2.a() || this.x) {
                return;
            }
            this.c.getClickCommon().click_area = "appinfo";
            this.w.show();
            this.x = true;
        } catch (Exception e2) {
            SigmobLog.e("openFourElements fail:" + e2.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public View P() {
        p pVar = this.k;
        if (pVar == null) {
            return null;
        }
        return (View) pVar.getParent();
    }

    private boolean Q() {
        return this.c.isExpiredAd();
    }

    private boolean R() {
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void S() {
        a(4, (MotionEvent) null);
    }

    private View a(HashSet<View> viewList, MotionEvent event) {
        if (viewList == null) {
            return null;
        }
        for (View view : viewList) {
            if (com.sigmob.sdk.base.utils.w.a(view, event)) {
                return view;
            }
        }
        return null;
    }

    private View a(List<View> viewList, MotionEvent event) {
        if (viewList == null) {
            return null;
        }
        for (View view : viewList) {
            if (com.sigmob.sdk.base.utils.w.a(view, event)) {
                return view;
            }
        }
        return null;
    }

    private List<View> a(List<View> list) {
        return list instanceof ArrayList ? list : new ArrayList(list);
    }

    /* JADX WARN: Code duplicated, block: B:25:0x0099  */
    /* JADX WARN: Code duplicated, block: B:37:0x00d1  */
    /* JADX WARN: Multi-variable type inference failed */
    private void a(int i, MotionEvent motionEvent) {
        TouchLocation touchLocation;
        TouchLocation touchLocation2;
        Object[] objArr;
        SigMacroCommon macroCommon;
        Long[] lArrA;
        com.sigmob.sdk.base.common.h.a(this.c);
        if (motionEvent == null) {
            touchLocation2 = null;
            touchLocation = null;
        } else {
            TouchLocation touchLocation3 = TouchLocation.getTouchLocation(P(), motionEvent);
            TouchLocation touchLocation4 = TouchLocation.getTouchLocation(P(), this.p);
            this.c.getClickCommon().down = touchLocation4;
            this.c.getClickCommon().up = touchLocation4;
            touchLocation = touchLocation3;
            touchLocation2 = touchLocation4;
        }
        this.c.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_PREVIEW;
        if (i == 1) {
            this.c.getClickCommon().click_area = "appinfo";
            this.c.getClickCommon().is_final_click = false;
            ah ahVarJ = j();
            if (ahVarJ != null) {
                ahVarJ.a("click", 0);
            }
            O();
            return;
        }
        if (i != 2) {
            if (i == 3) {
                objArr = false;
            } else if (i != 4) {
                return;
            } else {
                objArr = false;
            }
            if (objArr == false) {
                this.c.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
            }
            if (!(this.K && this.b.getAdPatternType() == 1) && this.c.getInteractionType() == 2) {
                this.c.getClickCommon().is_final_click = false;
            } else {
                this.c.getClickCommon().is_final_click = true;
            }
            if (com.sigmob.sdk.base.utils.v.b(this.c)) {
                macroCommon = this.c.getMacroCommon();
                lArrA = com.sigmob.sdk.base.utils.u.a(f3562a, motionEvent);
                if (com.sigmob.sdk.base.utils.v.b(macroCommon) && com.sigmob.sdk.base.utils.f.b(lArrA)) {
                    macroCommon.addMarcoKey(SigMacroCommon._DOWNTS_, String.valueOf(lArrA[0]));
                    macroCommon.addMarcoKey(SigMacroCommon._UPTS_, String.valueOf(lArrA[1]));
                }
            }
            y().a(N(), touchLocation2, touchLocation, com.sigmob.sdk.base.a.PREVIEW, this.c);
        }
        boolean zR = R();
        this.c.getClickCommon().click_area = ClickCommon.CLICK_AREA_MATERIAL;
        if (zR) {
            this.c.getClickCommon().is_final_click = false;
            j().a("click", 0);
            z();
            return;
        }
        objArr = true;
        if (objArr == false) {
            boolean zEnableWidgetInteraction = this.c.enableWidgetInteraction();
            boolean zEnableDevToRender = this.c.enableDevToRender(0);
            ClickCommon clickCommon = this.c.getClickCommon();
            clickCommon.click_area = ClickCommon.CLICK_AREA_COMPONENT;
            clickCommon.aim = Integer.valueOf(zEnableWidgetInteraction ? 1 : 0);
            clickCommon.cpt_render_type = Integer.valueOf(zEnableDevToRender ? 1 : 0);
            objArr = true;
        }
        if (objArr == false) {
            this.c.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
        }
        if (this.K) {
            this.c.getClickCommon().is_final_click = false;
        } else {
            this.c.getClickCommon().is_final_click = false;
        }
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            macroCommon = this.c.getMacroCommon();
            lArrA = com.sigmob.sdk.base.utils.u.a(f3562a, motionEvent);
            if (com.sigmob.sdk.base.utils.v.b(macroCommon)) {
                macroCommon.addMarcoKey(SigMacroCommon._DOWNTS_, String.valueOf(lArrA[0]));
                macroCommon.addMarcoKey(SigMacroCommon._UPTS_, String.valueOf(lArrA[1]));
            }
        }
        y().a(N(), touchLocation2, touchLocation, com.sigmob.sdk.base.a.PREVIEW, this.c);
    }

    private void a(ViewParent parent, int measuredWidth, int measuredHeight) {
        BaseAdUnit baseAdUnit;
        int i;
        Context contextN = N();
        if (contextN == null || parent == null || (baseAdUnit = this.c) == null) {
            return;
        }
        ViewGroup viewGroup = (ViewGroup) parent;
        if (baseAdUnit.enableWidgetInteraction()) {
            boolean zEnableDevToRender = this.c.enableDevToRender(0);
            if (zEnableDevToRender) {
                i = 30;
            } else {
                int iMin = Math.min(measuredHeight, measuredWidth);
                int iPixelsToIntDips = Dips.pixelsToIntDips(iMin, contextN);
                int iMin2 = Math.min(iPixelsToIntDips, 100);
                SigmobLogger.d(f3562a, "createWidget2Show: minViewSize = " + iMin + ", minViewSizeDp = " + iPixelsToIntDips + ", widgetSizeDp = " + iMin2, new Object[0]);
                i = iMin2;
            }
            float f2 = zEnableDevToRender ? 0.0f : 1.0f;
            String str = f3562a;
            SigmobLogger.d(str, "createWidget2Show: widgetSizeDp = " + i, new Object[0]);
            View viewA = a(i, i);
            if (viewA == null) {
                return;
            }
            viewA.setAlpha(f2);
            com.sigmob.sdk.base.utils.w.a(viewA);
            int measuredWidth2 = viewGroup.getMeasuredWidth();
            int measuredHeight2 = viewGroup.getMeasuredHeight();
            SigmobLogger.d(str, "createWidget2Show: containerW = " + measuredWidth2 + ", containerH = " + measuredHeight2, new Object[0]);
            FrameLayout frameLayout = new FrameLayout(viewGroup.getContext());
            frameLayout.setLayoutParams(new ViewGroup.LayoutParams(measuredWidth2, measuredHeight2));
            frameLayout.addView(viewA);
            viewGroup.addView(frameLayout);
            this.m.add(viewA);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(boolean z, com.sigmob.sdk.base.a aVar) {
        ah ahVarJ;
        NativeADEventListener nativeADEventListener;
        if (com.sigmob.sdk.base.utils.d.a(com.sigmob.sdk.base.utils.d.a(f3562a, this.c)) && (nativeADEventListener = this.r) != null) {
            nativeADEventListener.onAdClicked();
        }
        if (z && (ahVarJ = j()) != null) {
            ahVarJ.a("click", 0);
        }
    }

    private boolean a(MotionEvent event) {
        r rVar = this.j;
        if (rVar == null) {
            return false;
        }
        return rVar.a(event);
    }

    private r b(ViewGroup view) {
        for (int i = 0; i < view.getChildCount(); i++) {
            View childAt = view.getChildAt(i);
            if (childAt instanceof r) {
                return (r) childAt;
            }
        }
        return null;
    }

    private p c(ViewGroup view) {
        for (int i = 0; i < view.getChildCount(); i++) {
            View childAt = view.getChildAt(i);
            if (childAt instanceof p) {
                return (p) childAt;
            }
        }
        return null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void d(ViewGroup viewGroup) {
        a(a(viewGroup), viewGroup);
    }

    int A() {
        int interactionType = this.c.getInteractionType();
        if (interactionType == 2) {
            return 1;
        }
        return interactionType == 0 ? 0 : 2;
    }

    public String B() {
        return k().getCTAText();
    }

    public Bitmap C() {
        return this.v;
    }

    public void D() {
        r rVar;
        t tVarR;
        if (this.s || !this.D || (rVar = this.j) == null || rVar.getParent() == null || (tVarR = r()) == null) {
            return;
        }
        tVarR.c();
    }

    public void E() {
        t tVarR;
        if (this.s || (tVarR = r()) == null) {
            return;
        }
        this.A = true;
        tVarR.a();
    }

    public void F() {
        r rVar;
        if (this.t != null && (rVar = this.j) != null) {
            ViewParent parent = rVar.getParent();
            if (parent != null) {
                ((ViewGroup) parent).removeView(this.j);
            }
            this.t.removeAllViews();
            ViewGroup.LayoutParams layoutParams = this.u;
            if (layoutParams != null) {
                this.t.addView(this.j, layoutParams);
            } else {
                this.t.addView(this.j);
            }
            if (!this.m.contains(this.j)) {
                this.m.add(this.j);
            }
        }
        this.t = null;
        this.u = null;
    }

    public void G() {
        r rVar;
        t tVarR;
        if (this.s || !this.D || (rVar = this.j) == null || rVar.getParent() == null || (tVarR = r()) == null) {
            return;
        }
        tVarR.b();
    }

    public void H() {
        t tVarR;
        if (this.s || (tVarR = r()) == null) {
            return;
        }
        tVarR.d();
    }

    public String I() {
        BaseAdUnit baseAdUnit = this.c;
        return (baseAdUnit == null || baseAdUnit.bidding_response == null || this.c.bidding_response.ecpm == null) ? "" : String.valueOf(this.c.bidding_response.ecpm);
    }

    public String J() {
        BaseAdUnit baseAdUnit = this.c;
        return (baseAdUnit == null || baseAdUnit.bidding_response == null) ? "" : this.c.bidding_response.currency;
    }

    public String K() {
        SigVideo nativeVideo = this.c.getNativeVideo();
        if (nativeVideo == null) {
            return null;
        }
        return nativeVideo.getThumbUrl();
    }

    public WindAdMetaData L() {
        if (this.i == null) {
            this.i = WindAdMetaData.create(this.c);
        }
        return this.i;
    }

    public Map<String, String> M() {
        BaseAdUnit baseAdUnit = this.c;
        if (baseAdUnit == null) {
            return null;
        }
        return baseAdUnit.getSaasOptions();
    }

    public View a(int width, int height) {
        if (this.L == null && this.c != null) {
            Context contextN = N();
            x xVar = new x(contextN, this.c, Dips.dipsToIntPixels(width, contextN), Dips.dipsToIntPixels(height, contextN));
            if (!xVar.getCreateWidgetViewResult()) {
                return null;
            }
            xVar.setMotionActionListener(new d() { // from class: com.sigmob.sdk.nativead.ab$$ExternalSyntheticLambda0
                @Override // com.sigmob.sdk.nativead.d
                public final void onAction() {
                    this.f$0.S();
                }
            });
            int iDipsToIntPixels = Dips.dipsToIntPixels((width < 100 || height < 100) ? 30 : 70, contextN);
            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(iDipsToIntPixels, iDipsToIntPixels);
            layoutParams.gravity = 17;
            xVar.setLayoutParams(layoutParams);
            this.L = xVar;
        }
        return this.L;
    }

    public View a(ViewGroup parent) {
        View viewA;
        int measuredHeight;
        int measuredHeight2;
        View view = null;
        if (parent == null) {
            return null;
        }
        int i = 0;
        for (int i2 = 0; i2 < parent.getChildCount(); i2++) {
            View childAt = parent.getChildAt(i2);
            if (childAt != null) {
                if (childAt instanceof r) {
                    return childAt;
                }
                if ((childAt instanceof ImageView) && this.I.contains(childAt) && (measuredHeight2 = childAt.getMeasuredHeight() * childAt.getMeasuredWidth()) > i) {
                    view = childAt;
                    i = measuredHeight2;
                }
                if ((childAt instanceof ViewGroup) && (viewA = a((ViewGroup) childAt)) != null) {
                    if (viewA instanceof r) {
                        return viewA;
                    }
                    if ((viewA instanceof ImageView) && this.I.contains(viewA) && (measuredHeight = viewA.getMeasuredHeight() * viewA.getMeasuredWidth()) > i) {
                        view = viewA;
                        i = measuredHeight;
                    }
                }
            }
        }
        return view;
    }

    @Override // com.sigmob.sdk.base.common.x
    public void a() {
        e eVarY = y();
        if (eVarY == null) {
            return;
        }
        eVarY.a(N(), this.c);
    }

    public void a(View view, int i, int i2) {
        ViewGroup.LayoutParams layoutParams;
        ViewParent parent = view.getParent();
        if (parent == null) {
            return;
        }
        if (parent instanceof FrameLayout) {
            FrameLayout.LayoutParams layoutParams2 = (FrameLayout.LayoutParams) view.getLayoutParams();
            layoutParams2.width = i;
            layoutParams2.height = i2;
            layoutParams2.gravity = 17;
            layoutParams = layoutParams2;
        } else if (parent instanceof RelativeLayout) {
            RelativeLayout.LayoutParams layoutParams3 = (RelativeLayout.LayoutParams) view.getLayoutParams();
            layoutParams3.width = i;
            layoutParams3.height = i2;
            layoutParams3.addRule(13);
            layoutParams = layoutParams3;
        } else {
            if (!(parent instanceof LinearLayout)) {
                return;
            }
            LinearLayout.LayoutParams layoutParams4 = (LinearLayout.LayoutParams) view.getLayoutParams();
            layoutParams4.width = i;
            layoutParams4.height = i2;
            layoutParams4.gravity = 17;
            layoutParams = layoutParams4;
        }
        view.setLayoutParams(layoutParams);
        view.requestLayout();
    }

    public void a(View view, ViewGroup viewGroup) {
        ViewParent viewParent;
        View view2;
        if (viewGroup == null) {
            return;
        }
        if (view == null) {
            SigmobLogger.d(f3562a, "prepareWidget2Show: container", new Object[0]);
            view2 = viewGroup;
            viewParent = viewGroup;
        } else {
            if (!(view instanceof r) && !(view instanceof ImageView)) {
                SigmobLogger.d(f3562a, "prepareWidget2Show: no material", new Object[0]);
                return;
            }
            SigmobLogger.d(f3562a, "prepareWidget2Show: material", new Object[0]);
            ViewParent parent = view.getParent();
            view2 = view;
            viewParent = parent;
        }
        String simpleName = view2.getClass().getSimpleName();
        int measuredHeight = view2.getMeasuredHeight();
        int measuredWidth = view2.getMeasuredWidth();
        SigmobLogger.d(f3562a, "prepareWidget2Show: simpleName = " + simpleName + ", measuredHeight = " + measuredHeight + ", measuredWidth = " + measuredWidth, new Object[0]);
        a(viewParent, measuredWidth, measuredHeight);
    }

    public void a(View view, List<View> clickViewList, List<View> creativeViewList, View disLikeView, NativeADEventListener nativeADEventListener) {
        p pVar;
        ViewGroup.LayoutParams layoutParams;
        if (view == null) {
            if (nativeADEventListener != null) {
                nativeADEventListener.onAdError(WindAdError.ERROR_SIGMOB_ADCONTAINER_IS_NULL);
                return;
            }
            return;
        }
        if (!(view instanceof ViewGroup)) {
            if (nativeADEventListener != null) {
                nativeADEventListener.onAdError(WindAdError.ERROR_SIGMOB_ADCONTAINER_NOT_VIEWGROUP);
                return;
            }
            return;
        }
        if (com.sigmob.sdk.b.i() == null) {
            com.sigmob.sdk.b.a(com.sigmob.sdk.base.utils.w.d(view));
        }
        if (disLikeView != null) {
            if (this.y == null) {
                b bVar = new b(disLikeView.getContext(), this.c);
                this.y = bVar;
                bVar.a(this);
            }
            disLikeView.setOnTouchListener(new View.OnTouchListener() { // from class: com.sigmob.sdk.nativead.ab.3
                @Override // android.view.View.OnTouchListener
                public boolean onTouch(View v, MotionEvent event) {
                    if (event.getAction() != 1 || ab.this.y == null) {
                        return true;
                    }
                    ab.this.y.a();
                    return true;
                }
            });
        }
        final ViewGroup viewGroup = (ViewGroup) view;
        viewGroup.getViewTreeObserver().addOnGlobalLayoutListener(new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.sigmob.sdk.nativead.ab.4
            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public void onGlobalLayout() {
                viewGroup.getViewTreeObserver().removeOnGlobalLayoutListener(this);
                if (ab.this.c == null) {
                    return;
                }
                Context contextN = ab.this.N();
                int[] iArr = new int[2];
                viewGroup.getLocationOnScreen(iArr);
                ClickCommon clickCommon = ab.this.c.getClickCommon();
                clickCommon.adarea_x = String.valueOf(Dips.pixelsToIntDips(iArr[0], contextN));
                clickCommon.adarea_y = String.valueOf(Dips.pixelsToIntDips(iArr[1], contextN));
                clickCommon.adarea_w = String.valueOf(Dips.pixelsToIntDips(viewGroup.getWidth(), contextN));
                clickCommon.adarea_h = String.valueOf(Dips.pixelsToIntDips(viewGroup.getHeight(), contextN));
            }
        });
        x xVar = (x) com.sigmob.sdk.base.utils.w.a(viewGroup, x.class);
        if (xVar != null && xVar != this.L) {
            com.sigmob.sdk.base.utils.w.a(xVar);
        }
        viewGroup.post(new Runnable() { // from class: com.sigmob.sdk.nativead.ab$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.d(viewGroup);
            }
        });
        y().a(new com.sigmob.sdk.base.common.ac() { // from class: com.sigmob.sdk.nativead.ab$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.common.ac
            public final void onAdClick(boolean z, com.sigmob.sdk.base.a aVar) {
                this.f$0.a(z, aVar);
            }
        });
        if (com.sigmob.sdk.base.utils.f.b(creativeViewList)) {
            this.l = a(creativeViewList);
        }
        if (com.sigmob.sdk.base.utils.f.b(this.H)) {
            this.m.removeAll(this.H);
        }
        if (com.sigmob.sdk.base.utils.f.b(clickViewList)) {
            this.H = a(clickViewList);
        }
        this.r = nativeADEventListener;
        o().a((Map<String, Object>) null, this.c);
        com.sigmob.sdk.base.common.h.g().a(this.c, (com.sigmob.sdk.base.common.h.b) null);
        p pVar2 = this.k;
        if (pVar2 == null) {
            p pVarC = c(viewGroup);
            this.k = pVarC;
            if (pVarC == null) {
                pVar = new p(N());
                this.k = pVar;
                layoutParams = new ViewGroup.LayoutParams(0, 0);
            }
            this.m.addAll(this.H);
            this.k.setAdVisibilityStatusChangeListener(this);
            this.k.a(y().s(), y().t());
        }
        com.sigmob.sdk.base.utils.w.a(pVar2);
        pVar = this.k;
        layoutParams = new ViewGroup.LayoutParams(0, 0);
        viewGroup.addView(pVar, layoutParams);
        this.m.addAll(this.H);
        this.k.setAdVisibilityStatusChangeListener(this);
        this.k.a(y().s(), y().t());
    }

    public void a(ViewGroup mediaLayout, WindNativeAdData.NativeADMediaListener nativeADMediaListener) {
        this.K = true;
        b(mediaLayout, nativeADMediaListener);
    }

    public void a(BaseAdUnit adUnit, WindNativeAdData nativeAdUnit) {
        this.c = adUnit;
        this.b = nativeAdUnit;
        if (this.j == null && adUnit.getNativeAd().type.intValue() == 1) {
            this.j = new r(com.sigmob.sdk.b.e());
        }
        com.sigmob.sdk.base.common.h.a().getBitmap(k().getAd_source_logo(), new ImageManager.BitmapLoadedListener() { // from class: com.sigmob.sdk.nativead.ab.1
            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoadFailed() {
            }

            @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
            public void onBitmapLoaded(Bitmap bitmap) {
                ab.this.v = bitmap;
            }
        });
    }

    public void a(WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback) {
        this.J = dislikeInteractionCallback;
    }

    public void a(HashSet<View> viewList, View.OnTouchListener onTouchListener) {
        if (viewList == null) {
            return;
        }
        for (View view : viewList) {
            if (view != null) {
                view.setOnClickListener(null);
                view.setOnTouchListener(null);
                view.setOnTouchListener(onTouchListener);
            }
        }
    }

    public void a(List<ImageView> viewList, int resId) {
        List<SigImage> imageUrlList = k().getImageUrlList();
        if (viewList == null || imageUrlList == null) {
            return;
        }
        this.I.clear();
        this.I.addAll(viewList);
        int iMin = Math.min(viewList.size(), imageUrlList.size());
        for (int i = 0; i < iMin; i++) {
            SigImage sigImage = imageUrlList.get(i);
            ImageView imageView = viewList.get(i);
            if (!this.m.contains(imageView)) {
                this.m.add(imageView);
            }
            List<View> list = this.F;
            if (list == null) {
                this.F = new ArrayList();
            } else {
                list.clear();
            }
            this.F.add(imageView);
            com.sigmob.sdk.base.common.h.a().load(sigImage.getImageUrl()).placeholder(resId).error(resId).into(imageView);
        }
    }

    public void a(List<View> viewList, View.OnTouchListener onTouchListener) {
        if (viewList == null) {
            return;
        }
        for (View view : viewList) {
            if (view != null) {
                view.setOnClickListener(null);
                view.setOnTouchListener(null);
                view.setOnTouchListener(onTouchListener);
            }
        }
    }

    @Override // com.sigmob.sdk.nativead.a
    public void a(boolean isValidImpression) {
        if (this.z) {
            return;
        }
        if (!this.s) {
            com.sigmob.sdk.base.common.h.g().e(this.c);
            if (isValidImpression) {
                NativeADEventListener nativeADEventListener = this.r;
                if (nativeADEventListener != null) {
                    nativeADEventListener.onAdExposed();
                }
                j().a("ad_show", 0);
            }
        }
        this.z = isValidImpression;
    }

    @Override // com.sigmob.sdk.base.common.x
    public void b() {
        e eVarY = y();
        if (eVarY == null) {
            return;
        }
        eVarY.b(N(), this.c);
    }

    public void b(ViewGroup mediaContainer, final WindNativeAdData.NativeADMediaListener sigAdVideoEventListener) {
        if (mediaContainer == null) {
            return;
        }
        r rVar = (r) com.sigmob.sdk.base.utils.w.a(mediaContainer, r.class);
        if (rVar != null) {
            com.sigmob.sdk.base.utils.w.a(rVar);
        }
        r rVar2 = this.j;
        if (rVar2 != null) {
            com.sigmob.sdk.base.utils.w.a(rVar2);
            mediaContainer.addView(this.j, new ViewGroup.LayoutParams(-1, -2));
        }
        if (!this.m.contains(this.j)) {
            this.m.add(this.j);
        }
        r rVar3 = this.j;
        if (rVar3 != null && !this.c.equals(rVar3.getAdUnit())) {
            this.j.a(this);
        }
        r rVar4 = this.j;
        final t sigVideoAdController = rVar4 == null ? null : rVar4.getSigVideoAdController();
        if (sigVideoAdController == null) {
            return;
        }
        sigVideoAdController.a(new l() { // from class: com.sigmob.sdk.nativead.ab.2
            @Override // com.sigmob.sdk.nativead.l
            public void a() {
                ab.this.j().a("video_restart", 0);
            }

            @Override // com.sigmob.sdk.nativead.l
            public void a(long current, long duration) {
                List<com.sigmob.sdk.videoAd.d> listA;
                ab.this.c.getVideoCommon().end_time = sigVideoAdController.j();
                e eVarY = ab.this.y();
                if (eVarY == null || (listA = eVarY.a(current, duration)) == null || listA.isEmpty()) {
                    return;
                }
                for (com.sigmob.sdk.videoAd.d dVar : listA) {
                    ab.this.j().a(dVar.getEvent(), sigVideoAdController.j());
                    dVar.setTracked();
                }
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoCompleted() {
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener != null) {
                    nativeADMediaListener.onVideoCompleted();
                }
                ab.this.c.getVideoCommon().end_time = sigVideoAdController.e();
                ab.this.c.getVideoCommon().is_last = 1;
                ab.this.j().a("complete", sigVideoAdController.j());
                ab.this.j().a("video_link", 0);
                ab.this.C = false;
                ab.this.A = false;
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoError(WindAdError error) {
                ab.this.A = false;
                ab.this.C = false;
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener == null) {
                    return;
                }
                nativeADMediaListener.onVideoError(error);
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoLoad() {
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener == null) {
                    return;
                }
                nativeADMediaListener.onVideoLoad();
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoPause() {
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener != null) {
                    nativeADMediaListener.onVideoPause();
                }
                ab.this.C = true;
                ab.this.j().a("video_pause", 0);
                ab.this.j().a("video_link", 0);
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoResume() {
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener != null) {
                    nativeADMediaListener.onVideoResume();
                }
                ab.this.C = false;
                ab.this.c.getVideoCommon().type = 2;
                ab.this.c.getVideoCommon().is_first = 0;
                ab.this.c.getVideoCommon().begin_time = sigVideoAdController.j();
                ab.this.A = false;
                ab.this.j().a("video_start", sigVideoAdController.j());
            }

            @Override // com.sigmob.windad.natives.WindNativeAdData.NativeADMediaListener
            public void onVideoStart() {
                View viewP = ab.this.P();
                if (viewP != null) {
                    ab.this.c.setAdSize(viewP.getWidth(), viewP.getHeight());
                }
                ab.this.c.getVideoCommon().video_time = sigVideoAdController.e();
                ab.this.c.getVideoCommon().is_first = 1;
                ab.this.c.getVideoCommon().is_last = 0;
                ab.this.c.getVideoCommon().end_time = 0;
                ab.this.c.getVideoCommon().is_auto_play = ab.this.y().u() ? 1 : 2;
                if (ab.this.s) {
                    ab.this.c.getVideoCommon().scene = 3;
                } else {
                    ab.this.c.getVideoCommon().scene = 1;
                }
                if (ab.this.B) {
                    ab.this.c.getVideoCommon().type = 1;
                    ab.this.B = false;
                } else {
                    ab.this.c.getVideoCommon().type = 3;
                }
                WindNativeAdData.NativeADMediaListener nativeADMediaListener = sigAdVideoEventListener;
                if (nativeADMediaListener != null) {
                    nativeADMediaListener.onVideoStart();
                }
                ab.this.A = false;
                ab.this.C = false;
                ab.this.j().a("video_start", 0);
            }
        });
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit) {
        r rVar = this.j;
        if (rVar == null) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = ((View) rVar.getParent()).getLayoutParams();
        SigmobLog.d("visibilityStatusChange() called with: isVisible = [" + layoutParams.width + ":" + layoutParams.height + "]");
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit, String error) {
    }

    public void b(boolean mute) {
        t tVarR;
        if (this.s || (tVarR = r()) == null) {
            return;
        }
        tVarR.a(mute);
    }

    @Override // com.sigmob.sdk.nativead.a
    public void c() {
        if (this.D) {
            x xVar = this.L;
            if (xVar != null) {
                xVar.b();
                M.remove(this.L);
            }
            t tVarR = r();
            if (tVarR != null) {
                tVarR.a();
            }
            SigmobLog.d("-----------onAdViewPauseImpression---------");
            this.D = false;
        }
    }

    @Override // com.sigmob.sdk.base.common.p
    public void c(BaseAdUnit adUnit) {
    }

    @Override // com.sigmob.sdk.nativead.a
    public void d() {
        x xVarLastElement;
        x xVar;
        if (this.L != null) {
            Stack<x> stack = M;
            if (!stack.isEmpty() && (xVarLastElement = stack.lastElement()) != null && xVarLastElement == (xVar = this.L)) {
                xVar.a();
            }
        }
        if (this.s || this.D) {
            return;
        }
        this.D = true;
        x xVar2 = this.L;
        if (xVar2 != null) {
            Stack<x> stack2 = M;
            if (!stack2.contains(xVar2)) {
                stack2.push(this.L);
                this.L.a();
            }
        }
        r rVar = this.j;
        if (rVar == null || rVar.getParent() == null) {
            return;
        }
        e eVarY = y();
        if (!this.A && eVarY != null && eVarY.u()) {
            r().c();
        }
        SigmobLog.d("------------onAdViewStartImpression------------");
    }

    @Override // com.sigmob.sdk.base.common.p
    public void d(BaseAdUnit adUnit) {
    }

    @Override // com.sigmob.sdk.nativead.a
    public void e() {
        if (this.s || N() == null || !this.E) {
            return;
        }
        this.m.clear();
        this.E = false;
        x xVar = this.L;
        if (xVar != null) {
            xVar.b();
            M.remove(this.L);
        }
        SigmobLog.d("------------onAdViewRemoved----------" + hashCode());
        t tVarR = r();
        if (tVarR != null) {
            tVarR.a();
        }
        this.D = false;
        p pVar = this.k;
        if (pVar != null && pVar.hasWindowFocus()) {
            this.z = false;
        }
        ah ahVarJ = j();
        if (ahVarJ != null) {
            ahVarJ.a("ad_hide", 0);
        }
        if (this.B || this.C || ahVarJ == null) {
            return;
        }
        ahVarJ.a("video_link", 0);
    }

    @Override // com.sigmob.sdk.base.common.p
    public void e(BaseAdUnit mAdUnit) {
    }

    @Override // com.sigmob.sdk.nativead.a
    public void f() {
        if (this.E || this.s) {
            return;
        }
        this.E = true;
        com.sigmob.sdk.base.utils.k.c(f3562a, "onAdViewShow", new Object[0]);
        this.A = false;
        this.D = false;
        boolean zJ = com.sigmob.sdk.base.o.a().j();
        View viewP = P();
        if (com.sigmob.sdk.base.utils.v.b(viewP)) {
            y().a(com.sigmob.sdk.base.utils.w.c(viewP), this.c, this.N);
            if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(zJ))) {
                viewP.setOnTouchListener(this);
            }
        }
        r rVar = this.j;
        if (rVar != null && !this.m.contains(rVar)) {
            this.m.add(this.j);
        } else if (this.F != null) {
            if (this.m.isEmpty()) {
                this.m.addAll(this.F);
            } else {
                for (View view : this.F) {
                    if (!this.m.contains(view)) {
                        this.m.add(view);
                    }
                }
            }
        }
        x xVar = this.L;
        if (xVar != null && !this.m.contains(xVar)) {
            this.m.add(this.L);
        }
        this.m.addAll(this.H);
        a(this.l, this);
        if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(zJ))) {
            a(this.m, this);
        }
        ah ahVarJ = j();
        if (ahVarJ == null) {
            return;
        }
        ahVarJ.a("start", 0);
    }

    @Override // com.sigmob.sdk.nativead.g
    public void g() {
        SigmobLog.d("----------onAdDetailShow----------");
        if (y() != null) {
            y().c(N(), this.c);
        }
        this.s = true;
        NativeADEventListener nativeADEventListener = this.r;
        if (nativeADEventListener != null) {
            nativeADEventListener.onAdDetailShow();
        }
    }

    @Override // com.sigmob.sdk.nativead.g
    public void h() {
    }

    @Override // com.sigmob.sdk.nativead.g
    public void i() {
        this.s = false;
        NativeADEventListener nativeADEventListener = this.r;
        if (nativeADEventListener != null) {
            nativeADEventListener.onAdDetailDismiss();
        }
        e eVarY = y();
        if (eVarY != null) {
            eVarY.d(N(), this.c);
        }
        F();
        n nVar = this.o;
        if (nVar != null) {
            nVar.setVisibility(0);
        }
        f fVar = this.n;
        if (fVar != null) {
            fVar.b(this.c);
        }
        View viewP = P();
        if (viewP == null || eVarY == null) {
            return;
        }
        eVarY.a(com.sigmob.sdk.base.utils.w.c(viewP), this.c, this.N);
    }

    public ah j() {
        BaseAdUnit baseAdUnit = this.c;
        if (baseAdUnit == null) {
            return null;
        }
        ah sessionManager = baseAdUnit.getSessionManager();
        if (sessionManager != null) {
            return sessionManager;
        }
        i iVar = new i();
        iVar.a(this.c);
        return iVar;
    }

    @Override // com.sigmob.sdk.nativead.ac
    public BaseAdUnit k() {
        return this.c;
    }

    @Override // com.sigmob.sdk.nativead.ac
    public WindNativeAdData l() {
        return this.b;
    }

    @Override // com.sigmob.sdk.nativead.ac
    public n m() {
        if (this.K) {
            return this.o;
        }
        if (this.o == null) {
            if (this.c.getadPrivacy() == null) {
                return this.o;
            }
            n nVar = new n(N());
            this.o = nVar;
            nVar.setOnTouchListener(this);
            this.o.a(this.c.getAppVersion(), this.c.getCompanyName());
        }
        return this.o;
    }

    public boolean n() {
        f fVar = this.n;
        if (fVar == null) {
            return false;
        }
        return fVar.a(this.c);
    }

    public f o() {
        if (this.n == null) {
            this.n = new f(this);
        }
        return this.n;
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
    public void onCancel() {
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.J;
        if (dislikeInteractionCallback == null) {
            return;
        }
        dislikeInteractionCallback.onCancel();
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View v) {
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
    public void onSelected(int position, String value, boolean enforce) {
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.J;
        if (dislikeInteractionCallback == null) {
            return;
        }
        dislikeInteractionCallback.onSelected(position, value, enforce);
    }

    @Override // com.sigmob.windad.natives.WindNativeAdData.DislikeInteractionCallback
    public void onShow() {
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.J;
        if (dislikeInteractionCallback == null) {
            return;
        }
        dislikeInteractionCallback.onShow();
    }

    @Override // android.view.View.OnTouchListener
    public boolean onTouch(View v, MotionEvent event) {
        if (v == null || event == null || ((event.getAction() == 0 && this.G > 0 && System.currentTimeMillis() - this.G < 500) || this.c == null)) {
            return false;
        }
        try {
            if (event.getAction() != 1) {
                this.G = System.currentTimeMillis();
                this.p = event;
                return true;
            }
            this.c.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_PREVIEW;
            this.c.getClickCommon().sld = "0";
            if (v == this.o) {
                SigmobLog.d("click mSigAppInfoView");
                a(1, event);
                return true;
            }
            SigmobLog.d("click " + v);
            List<View> list = this.l;
            int i = 3;
            if (list != null) {
                if ((list.contains(v) ? v : a(this.l, event)) != null) {
                    SigmobLog.d("click ctaClickView");
                    this.c.getClickCommon().click_scene = ClickCommon.CLICK_SCENE_PREVIEW;
                    this.c.getClickCommon().click_area = ClickCommon.CLICK_AREA_BTN;
                    a(3, event);
                    return true;
                }
            }
            if (this.m.isEmpty()) {
                return false;
            }
            if (!this.m.contains(v)) {
                v = a(this.m, event);
            }
            if (v != null) {
                SigmobLog.d("click mCreativeViews");
                r rVar = this.j;
                if (!(rVar != null && rVar.a(event))) {
                    i = 2;
                }
                a(i, event);
                return true;
            }
            return false;
        } catch (Throwable th) {
            SigmobLog.e("onTouch error", th);
        }
    }

    public int p() {
        int width;
        View viewP = P();
        if (this.j == null || viewP == null || (width = viewP.getWidth()) <= 0) {
            return 1280;
        }
        return width;
    }

    public View q() {
        return this.j;
    }

    public t r() {
        r rVar = this.j;
        if (rVar == null) {
            return null;
        }
        return rVar.getSigVideoAdController();
    }

    public int s() {
        t tVarR = r();
        if (tVarR == null) {
            return 0;
        }
        return tVarR.e() * 1000;
    }

    public int t() {
        t tVarR = r();
        if (tVarR == null) {
            return 0;
        }
        return tVarR.j() * 1000;
    }

    public int u() {
        t tVarR = r();
        if (tVarR == null) {
            return 0;
        }
        return tVarR.f();
    }

    public int v() {
        View viewQ = q();
        View viewP = P();
        if (viewQ == null || viewP == null || viewP.getWidth() <= 0) {
            return 720;
        }
        return (int) (((double) viewP.getWidth()) / this.c.getAdPercent());
    }

    public void w() {
        a(this.m, (View.OnTouchListener) null);
        a(this.l, (View.OnTouchListener) null);
        this.m.clear();
        List<View> list = this.l;
        if (list != null) {
            list.clear();
        }
        List<View> list2 = this.H;
        if (list2 != null) {
            list2.clear();
        }
        this.r = null;
        this.d = null;
    }

    public void x() {
        Object[] objArr = new Object[1];
        BaseAdUnit baseAdUnit = this.c;
        objArr[0] = baseAdUnit != null ? baseAdUnit.getVid() : "null";
        SigmobLog.i(String.format("native ad data %s is Destroy", objArr));
        w();
        List<View> list = this.F;
        if (list != null) {
            list.clear();
        }
        r rVar = this.j;
        if (rVar != null) {
            com.sigmob.sdk.base.utils.w.a(rVar);
            this.j.c();
            this.j = null;
        }
        BaseAdUnit baseAdUnit2 = this.c;
        if (baseAdUnit2 != null && baseAdUnit2.getSessionManager() != null) {
            j().a("ad_hide", 0);
            j().a();
        }
        x xVar = this.L;
        if (xVar != null) {
            xVar.c();
            M.remove(this.L);
            com.sigmob.sdk.base.utils.w.a(this.L);
            this.L = null;
        }
        com.sigmob.sdk.base.common.h.g().e(this.c);
        com.sigmob.sdk.base.common.h.b(this.c);
        com.sigmob.sdk.base.views.q qVar = this.w;
        if (qVar != null) {
            qVar.dismiss();
            this.w.c();
            this.w = null;
        }
        v vVar = this.y;
        if (vVar != null && (vVar instanceof b)) {
            vVar.a(null);
            b bVar = (b) this.y;
            bVar.dismiss();
            bVar.b();
            this.y = null;
        }
        this.J = null;
        this.N = null;
        p pVar = this.k;
        if (pVar != null) {
            pVar.setAdVisibilityStatusChangeListener(null);
            com.sigmob.sdk.base.utils.w.a(this.k);
            this.k = null;
        }
        f fVar = this.n;
        if (fVar != null) {
            fVar.b(this.c);
            this.n = null;
        }
        BaseAdUnit baseAdUnit3 = this.c;
        if (baseAdUnit3 != null) {
            baseAdUnit3.destroy();
        }
    }

    @Override // com.sigmob.sdk.nativead.ac
    public e y() {
        BaseAdUnit baseAdUnit;
        if (this.q == null && (baseAdUnit = this.c) != null) {
            this.q = (e) baseAdUnit.getAdConfig();
        }
        return this.q;
    }

    public void z() {
        Bundle bundle = new Bundle();
        if (this.j != null && y().l()) {
            ae aeVar = new ae();
            int[] iArr = new int[2];
            this.j.getLocationOnScreen(iArr);
            aeVar.a(iArr[0]);
            aeVar.b(iArr[1]);
            aeVar.c(this.j.getMeasuredWidth());
            aeVar.d(this.j.getMeasuredHeight());
            bundle.putParcelable("attr", aeVar);
            this.t = (ViewGroup) this.j.getParent();
            this.u = this.j.getLayoutParams();
            z.a((m) this.j);
            SigMacroCommon macroCommon = this.c.getMacroCommon();
            if (macroCommon != null) {
                macroCommon.addMarcoKey(SigMacroCommon._SCENE_, "3");
            }
            this.s = true;
        }
        n nVar = this.o;
        if (nVar != null) {
            nVar.setVisibility(4);
        }
        o().a(this.c, bundle);
    }
}
