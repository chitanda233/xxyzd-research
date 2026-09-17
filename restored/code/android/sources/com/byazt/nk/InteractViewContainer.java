package com.byazt.nk;

import android.content.Context;
import android.graphics.Color;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.byazt.oq.CircleLongPressView;
import com.byazt.oq.ClickSlideUpShakeView;
import com.byazt.oq.RippleView;
import com.byazt.oq.ShakeAnimationView;
import com.byazt.oq.WriggleGuideAnimationView;
import com.byazt.tm.DynamicBaseWidget;
import com.sigmob.sdk.base.mta.PointType;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 234, 2265})
public class InteractViewContainer extends FrameLayout implements x {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1212a;
    public Context c;
    public boolean da;
    public int i;
    public sp n;
    public com.byazt.aq.da sl;
    public RippleView sp;
    public com.byazt.xl.u t;
    public DynamicBaseWidget tt;
    public View uj;
    public com.byazt.aq.sp ve;
    public View.OnTouchListener x;

    public InteractViewContainer(Context context, DynamicBaseWidget dynamicBaseWidget, com.byazt.aq.sp spVar) {
        super(context);
        this.c = context;
        this.tt = dynamicBaseWidget;
        this.ve = spVar;
        sp();
    }

    public InteractViewContainer(Context context, DynamicBaseWidget dynamicBaseWidget, com.byazt.aq.sp spVar, com.byazt.aq.da daVar, com.byazt.xl.u uVar) {
        super(context);
        this.c = context;
        this.tt = dynamicBaseWidget;
        this.ve = spVar;
        this.sl = daVar;
        this.t = uVar;
        sp();
    }

    private void sp() {
        setBackgroundColor(0);
        setClipChildren(false);
        setClipToPadding(false);
        this.f1212a = this.ve.aw();
        this.i = this.ve.bm();
        this.da = this.ve.kp();
        sp spVarC = i.c(this.c, this.tt, this.ve, this.sl, this.t);
        this.n = spVarC;
        if (spVarC != null) {
            this.uj = spVarC.ve();
            if (this.ve.ic()) {
                setBackgroundColor(Color.parseColor("#50000000"));
            }
            if (TextUtils.equals(this.f1212a, "6")) {
                if (this.ve.b() && !TextUtils.isEmpty(this.ve.q())) {
                    this.sp = new RippleView(this.c, com.byazt.aq.sp.c(this.ve.q()));
                } else {
                    this.sp = new RippleView(this.c, Color.parseColor("#99000000"));
                }
                FrameLayout frameLayout = new FrameLayout(this.c);
                frameLayout.addView(this.sp, new FrameLayout.LayoutParams(-1, -1));
                frameLayout.setClipChildren(true);
                addView(frameLayout, new FrameLayout.LayoutParams(-1, -1));
                post(new Runnable() { // from class: com.byazt.nk.InteractViewContainer.1
                    @Override // java.lang.Runnable
                    public void run() {
                        InteractViewContainer.this.sp.tt();
                    }
                });
            }
            if (c(this.f1212a) && com.byazt.sr.uj.c()) {
                int color = Color.parseColor("#99000000");
                if (this.ve.b() && !TextUtils.isEmpty(this.ve.q())) {
                    try {
                        color = com.byazt.aq.sp.c(this.ve.q());
                    } catch (Exception unused) {
                    }
                }
                View view = new View(this.c);
                view.setBackgroundColor(color);
                addView(view, new FrameLayout.LayoutParams(-1, -1));
            }
            addView(this.n.ve());
            c(this.n.ve());
            setVisibility(0);
        }
    }

    private boolean c(String str) {
        return TextUtils.equals(str, "24") || TextUtils.equals(str, "23") || TextUtils.equals(str, "25") || TextUtils.equals(str, "22") || TextUtils.equals(str, "1");
    }

    @Override // android.view.ViewGroup
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        if (this.x instanceof com.byazt.ij.ve) {
            return true;
        }
        return super.onInterceptTouchEvent(motionEvent);
    }

    private void c(ViewGroup viewGroup) {
        if (this.uj == null) {
            return;
        }
        String str = this.f1212a;
        str.hashCode();
        switch (str) {
            case "0":
                this.x = new com.byazt.ij.n(this, this.i, this.t.h());
                setBackgroundColor(Color.parseColor("#80000000"));
                break;
            case "1":
            case "6":
                if (!this.ve.b() || TextUtils.isEmpty(this.ve.q())) {
                    setBackgroundColor(Color.parseColor("#80000000"));
                }
                this.x = new com.byazt.ij.a(this);
                break;
            case "2":
            case "7":
                setBackgroundColor(Color.parseColor("#80000000"));
                this.x = new com.byazt.ij.tt(this, this);
                break;
            case "5":
                if (this.ve.b() && !TextUtils.isEmpty(this.ve.q())) {
                    setBackgroundColor(com.byazt.aq.sp.c(this.ve.q()));
                } else {
                    setBackgroundColor(Color.parseColor("#80000000"));
                }
                this.x = new com.byazt.ij.ve(this);
                this.uj.setTag(2);
                break;
            case "8":
            case "11":
                this.tt.setClipChildren(false);
                this.tt.setClipChildren(false);
                ViewGroup viewGroup2 = (ViewGroup) this.tt.getParent();
                if (viewGroup2 != null) {
                    viewGroup2.setClipChildren(false);
                    viewGroup2.setClipToPadding(false);
                }
                this.x = new com.byazt.ij.a(this);
                break;
            case "9":
            case "17":
                this.uj.setTag(2);
                break;
            case "10":
                this.x = new com.byazt.ij.uj(this, this.i, this.da);
                break;
            case "12":
                this.x = new com.byazt.ij.ve(this);
                this.uj.setTag(2);
                break;
            case "13":
            case "24":
                if (this.f1212a.equals("24") && com.byazt.sr.uj.c()) {
                    this.tt.setClipChildren(false);
                    this.x = new com.byazt.ij.a(this);
                    break;
                } else {
                    this.x = new com.byazt.ij.n(this, this.i, this.t.h());
                    break;
                }
                break;
            case "14":
                this.x = new com.byazt.ij.tt(this, this);
                break;
            case "16":
                View view = this.uj;
                if (view != null && (view instanceof ShakeAnimationView) && ((ShakeAnimationView) view).getShakeLayout() != null) {
                    ((ShakeAnimationView) this.uj).getShakeLayout().setTag(2);
                }
                this.uj.setTag(2);
                break;
            case "18":
                View view2 = this.uj;
                if (view2 != null && (view2 instanceof WriggleGuideAnimationView) && ((WriggleGuideAnimationView) view2).getWriggleLayout() != null) {
                    ((WriggleGuideAnimationView) this.uj).getWriggleLayout().setTag(2);
                }
                this.uj.setTag(2);
                break;
            case "20":
                this.x = new com.byazt.ij.c(this, this.i, viewGroup);
                break;
            case "22":
                if (com.byazt.sr.uj.c()) {
                    this.x = new com.byazt.ij.x(this, this.da);
                    break;
                } else {
                    this.x = new com.byazt.ij.sp(this, this.i, viewGroup);
                    break;
                }
                break;
            case "23":
                if (com.byazt.sr.uj.c()) {
                    this.x = new com.byazt.ij.a(this);
                    break;
                }
                break;
            case "25":
                if (com.byazt.sr.uj.c()) {
                    this.x = new com.byazt.ij.x(this, this.da);
                    break;
                }
                break;
            case "29":
                View view3 = this.uj;
                if (view3 != null && (view3 instanceof ClickSlideUpShakeView) && ((ClickSlideUpShakeView) view3).getShakeView() != null) {
                    ((ClickSlideUpShakeView) this.uj).getShakeView().setTag(2);
                }
                this.x = new com.byazt.ij.n(this, this.i, this.t.h());
                break;
        }
        View.OnTouchListener onTouchListener = this.x;
        if (onTouchListener != null) {
            setOnTouchListener(onTouchListener);
        }
        if (x()) {
            this.uj.setTag(2);
            setOnClickListener((View.OnClickListener) this.tt.getDynamicClickListener());
        }
    }

    private boolean x() {
        return (this.ve.kp() || TextUtils.equals("9", this.f1212a) || TextUtils.equals("16", this.f1212a) || TextUtils.equals(PointType.LOAD_READY, this.f1212a) || TextUtils.equals("18", this.f1212a) || TextUtils.equals("20", this.f1212a) || TextUtils.equals("29", this.f1212a) || TextUtils.equals(PointType.SIGMOB_APP, this.f1212a)) ? false : true;
    }

    public void ve() {
        sp spVar = this.n;
        if (spVar != null) {
            spVar.c();
        }
    }

    public void uj() {
        sp spVar = this.n;
        if (spVar != null) {
            spVar.tt();
        }
    }

    @Override // android.view.ViewGroup, android.view.View
    public void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        try {
            sp spVar = this.n;
            if (spVar != null) {
                spVar.tt();
            }
        } catch (Exception e) {
            com.byazt.nr.m.ve(e.getMessage());
        }
    }

    public void n() {
        if (this.uj != null && TextUtils.equals(this.f1212a, "2")) {
            View view = this.uj;
            if (view instanceof CircleLongPressView) {
                ((CircleLongPressView) view).ve();
            }
        }
    }

    public void a() {
        if (this.uj != null && TextUtils.equals(this.f1212a, "2")) {
            View view = this.uj;
            if (view instanceof CircleLongPressView) {
                ((CircleLongPressView) view).uj();
            }
        }
    }

    @Override // com.byazt.nk.x
    public void c() {
        if (TextUtils.equals(this.f1212a, "6")) {
            RippleView rippleView = this.sp;
            if (rippleView != null) {
                rippleView.ve();
                postDelayed(new Runnable() { // from class: com.byazt.nk.InteractViewContainer.2
                    @Override // java.lang.Runnable
                    public void run() {
                        InteractViewContainer.this.i();
                    }
                }, 300L);
                return;
            }
            return;
        }
        if (TextUtils.equals(this.f1212a, "20")) {
            postDelayed(new Runnable() { // from class: com.byazt.nk.InteractViewContainer.3
                @Override // java.lang.Runnable
                public void run() {
                    InteractViewContainer.this.i();
                }
            }, 400L);
        } else {
            i();
        }
    }

    @Override // com.byazt.nk.x
    public void tt() {
        if (x()) {
            setOnClickListener((View.OnClickListener) this.tt.getDynamicClickListener());
            performClick();
            if (this.ve.ma()) {
                return;
            }
            setVisibility(8);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void i() {
        if (this.x != null) {
            setOnClickListener((View.OnClickListener) this.tt.getDynamicClickListener());
            performClick();
            if (this.ve.ma()) {
                return;
            }
            setVisibility(8);
        }
    }
}
