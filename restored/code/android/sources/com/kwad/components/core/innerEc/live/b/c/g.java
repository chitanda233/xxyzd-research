package com.kwad.components.core.innerEc.live.b.c;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Rect;
import android.os.Handler;
import android.os.Looper;
import android.text.Editable;
import android.text.TextUtils;
import android.text.TextWatcher;
import android.view.KeyEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.view.animation.DecelerateInterpolator;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.widget.KSLinearLayout;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.core.innerEc.live.b.a.a {
    private EditText VA;
    private View VB;
    private String WA;
    private TextView WB;
    private View WC;
    private ViewGroup.MarginLayoutParams WD;
    private int WE;
    private int WF;
    private boolean Wq;
    private ViewGroup.MarginLayoutParams Wx;
    private KSLinearLayout Wy;
    private ViewGroup Wz;
    private ViewTreeObserver.OnGlobalLayoutListener qw;
    private final Handler jc = new Handler(Looper.getMainLooper());
    private boolean Wr = false;
    private int Ws = 0;
    private boolean Wt = false;
    private boolean Wu = false;
    private int Wv = 0;
    private ValueAnimator Ww = null;

    static /* synthetic */ boolean a(g gVar, int i, int i2) {
        return k(i, i2);
    }

    static /* synthetic */ boolean a(g gVar, boolean z) {
        gVar.Wu = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        KSLinearLayout kSLinearLayout = (KSLinearLayout) findViewById(R.id.ksad_comment_edit_layout);
        this.Wy = kSLinearLayout;
        this.Wx = (ViewGroup.MarginLayoutParams) kSLinearLayout.getLayoutParams();
        ViewGroup viewGroup = (ViewGroup) findViewById(R.id.comment_edit_root);
        this.Wz = viewGroup;
        viewGroup.setVisibility(8);
        this.VA = (EditText) findViewById(R.id.ksad_comment_edit);
        View viewFindViewById = findViewById(R.id.ksad_comment_send);
        this.VB = viewFindViewById;
        viewFindViewById.setVisibility(8);
        this.WB = (TextView) findViewById(R.id.ksad_comment_edit_count);
        View viewFindViewById2 = findViewById(R.id.ksad_live_ad_container);
        this.WC = viewFindViewById2;
        ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) viewFindViewById2.getLayoutParams();
        this.WD = marginLayoutParams;
        this.WE = marginLayoutParams.bottomMargin;
        KSLinearLayout kSLinearLayout2 = this.Wy;
        kSLinearLayout2.setRadius(com.kwad.sdk.c.a.a.a(kSLinearLayout2.getContext(), 24.0f), com.kwad.sdk.c.a.a.a(this.Wy.getContext(), 24.0f), 0.0f, 0.0f);
        this.WF = com.kwad.sdk.c.a.a.l(getActivity());
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Uj.UW = new com.kwad.sdk.g.b<Object, Object>() { // from class: com.kwad.components.core.innerEc.live.b.c.g.1
            @Override // com.kwad.sdk.g.b
            public final Object apply(Object obj) {
                g.a(g.this, true);
                g.this.Wz.setVisibility(0);
                g.this.VA.requestFocus();
                g.this.Wy.setVisibility(0);
                g.this.sA();
                return null;
            }
        };
        sv();
        sw();
        sx();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        sz();
        so();
    }

    private void sv() {
        int iSW = com.kwad.components.core.innerEc.live.i.c.sW();
        if (iSW >= 0) {
            aO(iSW);
        } else {
            aO(com.kwad.components.core.innerEc.live.i.c.c(ServiceProvider.getContext(), false));
        }
    }

    private void sw() {
        if (this.qw == null) {
            this.qw = y(findViewById(R.id.ksad_live_frag_root));
        }
        getRootView().getViewTreeObserver().addOnGlobalLayoutListener(this.qw);
    }

    private void sx() {
        this.VA.setOnEditorActionListener(new TextView.OnEditorActionListener() { // from class: com.kwad.components.core.innerEc.live.b.c.g.2
            @Override // android.widget.TextView.OnEditorActionListener
            public final boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                if (keyEvent == null) {
                    return false;
                }
                return i == 6 || keyEvent.getKeyCode() == 66;
            }
        });
        this.VA.addTextChangedListener(new TextWatcher() { // from class: com.kwad.components.core.innerEc.live.b.c.g.3
            @Override // android.text.TextWatcher
            public final void afterTextChanged(Editable editable) {
            }

            @Override // android.text.TextWatcher
            public final void beforeTextChanged(CharSequence charSequence, int i, int i2, int i3) {
            }

            @Override // android.text.TextWatcher
            public final void onTextChanged(CharSequence charSequence, int i, int i2, int i3) {
                g.this.WA = charSequence.toString().trim().replace("\n", "").replace("\r", "");
                g.this.VB.setVisibility(TextUtils.isEmpty(g.this.WA) ? 8 : 0);
                g.this.VA.setHeight((g.this.VA.getLineHeight() * g.this.VA.getLineCount()) + com.kwad.sdk.c.a.a.a(g.this.getContext(), 16.0f));
                if (g.this.WA.length() > 34) {
                    g.this.VA.setText(g.this.WA.subSequence(0, 34));
                    g.this.VA.setSelection(g.this.WA.length());
                    ae.W(ServiceProvider.getContext(), "字数超出最大限制");
                }
                g.this.WB.setVisibility(g.this.WA.length() > 22 ? 0 : 8);
                g.this.WB.setText(String.valueOf(34 - g.this.WA.length()));
                g.this.WB.setTextColor(Color.parseColor(g.this.WA.length() == 34 ? "#FE3666" : "#C6C6C6"));
            }
        });
    }

    private ViewTreeObserver.OnGlobalLayoutListener y(final View view) {
        return new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.kwad.components.core.innerEc.live.b.c.g.4
            private int WH = 0;
            private boolean WI = false;

            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public final void onGlobalLayout() {
                Context context = ServiceProvider.getContext();
                if (g.this.getActivity() != null) {
                    g.this.getActivity().getWindow();
                }
                int iAy = com.kwad.components.core.innerEc.live.i.c.ay(context);
                Rect rect = new Rect();
                view.getWindowVisibleDisplayFrame(rect);
                int[] iArr = new int[2];
                view.getLocationOnScreen(iArr);
                int height = view.getHeight();
                com.kwad.sdk.core.d.c.w("LiveInputPresenter", "rect:" + rect + ",location:" + Arrays.toString(iArr) + ", viewHeight: " + height);
                int iHeight = rect.height();
                if (iHeight <= height) {
                    height = iHeight;
                }
                int i = height - 0;
                com.kwad.sdk.core.d.c.w("LiveInputPresenter", "visibleHeight:" + i + ",curNavigationVisible:false,curNavigationHeight:0,location[1]:" + iArr[1]);
                int i2 = i - this.WH;
                int iB = com.kwad.components.core.innerEc.live.i.c.b(ServiceProvider.getContext(), false);
                int i3 = i2 - 0;
                int i4 = this.WH;
                if (i4 == 0 || i4 == i) {
                    if (!g.this.Wq && this.WH == i && !g.this.Wr) {
                        g.this.jc.removeCallbacksAndMessages(null);
                        g.this.jc.postDelayed(new bi() { // from class: com.kwad.components.core.innerEc.live.b.c.g.4.1
                            @Override // com.kwad.sdk.utils.bi
                            public final void doTask() {
                                g.this.sy();
                            }
                        }, 600L);
                    }
                    this.WH = i;
                    this.WI = false;
                    return;
                }
                if (!g.a(g.this, Math.abs(i3) + rect.top + this.WH + 0, iB) && !g.a(g.this, Math.abs(i3) + rect.top + i + 0, iB) && ((g.this.Ws <= 0 || !g.a(g.this, Math.abs(i3), g.this.Ws)) && ((com.kwad.components.core.innerEc.live.i.c.sW() <= 0 || !g.a(g.this, Math.abs(i3), com.kwad.components.core.innerEc.live.i.c.sW())) && (g.this.Wq || Math.abs(i3) <= com.kwad.components.core.innerEc.live.i.c.ax(g.this.getContext()))))) {
                    if (!g.this.Wq) {
                        Math.abs(i3);
                        com.kwad.components.core.innerEc.live.i.c.ax(g.this.getContext());
                    }
                    if ((!this.WI || !g.a(g.this, Math.abs(i3), iAy)) && g.this.Wq) {
                        int iBx = com.kwad.sdk.c.a.a.bx(ServiceProvider.getContext());
                        if (iBx <= 0) {
                            iBx = (iB - (rect.top + i)) + 0;
                        }
                        g.this.Ws = iBx;
                        g gVar = g.this;
                        gVar.aN(gVar.Ws);
                        com.kwad.components.core.innerEc.live.i.c.aS(g.this.Ws);
                    }
                } else if (i3 >= 0) {
                    g.this.aN(0);
                } else {
                    if (this.WI) {
                        i3 -= iAy;
                    }
                    g.this.Ws = -i3;
                    g gVar2 = g.this;
                    gVar2.aM(gVar2.Ws);
                    com.kwad.components.core.innerEc.live.i.c.aS(g.this.Ws);
                }
                this.WH = i;
                this.WI = false;
            }
        };
    }

    private static boolean k(int i, int i2) {
        return Math.abs(i - i2) <= 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sy() {
        this.Wr = true;
        if (this.Wt && !this.Wq && com.kwad.sdk.c.a.a.bx(ServiceProvider.getContext()) == 0) {
            this.Ws = 0;
            aM(0);
            com.kwad.components.core.innerEc.live.i.c.aS(this.Ws);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aM(int i) {
        aO(i);
        this.Wq = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aN(int i) {
        if (this.Wq) {
            if (i == 0) {
                so();
            }
            aO(i);
        }
    }

    private void aO(int i) {
        if (this.Wu) {
            final boolean z = ((float) i) < 200.0f;
            if (this.Wv != i) {
                ValueAnimator valueAnimator = this.Ww;
                if (valueAnimator != null) {
                    valueAnimator.cancel();
                }
                this.Wv = i;
                ValueAnimator valueAnimatorOfInt = ValueAnimator.ofInt(this.Wx.bottomMargin, i);
                this.Ww = valueAnimatorOfInt;
                valueAnimatorOfInt.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.core.innerEc.live.b.c.g.5
                    @Override // android.animation.ValueAnimator.AnimatorUpdateListener
                    public final void onAnimationUpdate(ValueAnimator valueAnimator2) {
                        g.this.Wx.bottomMargin = ((Integer) valueAnimator2.getAnimatedValue()).intValue();
                        g.this.Wy.setLayoutParams(g.this.Wx);
                        if (z) {
                            g.this.WD.bottomMargin = (g.this.WE - ((Integer) valueAnimator2.getAnimatedValue()).intValue()) + 66;
                        } else {
                            g.this.WD.bottomMargin = (g.this.WE + ((Integer) valueAnimator2.getAnimatedValue()).intValue()) - 66;
                        }
                        g.this.WC.setLayoutParams(g.this.WD);
                    }
                });
                this.Ww.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.core.innerEc.live.b.c.g.6
                    @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                    public final void onAnimationEnd(Animator animator) {
                        super.onAnimationEnd(animator);
                        if (z) {
                            g.this.Wz.setVisibility(8);
                            g.this.WD.bottomMargin = g.this.WE;
                            g.this.WC.setLayoutParams(g.this.WD);
                        }
                    }

                    @Override // android.animation.Animator.AnimatorListener
                    public final void onAnimationStart(Animator animator, boolean z2) {
                        super.onAnimationStart(animator, z2);
                    }
                });
                this.Ww.setDuration(z ? 30L : 200L);
                this.Ww.setInterpolator(new DecelerateInterpolator());
                this.Ww.start();
            }
        }
    }

    private void so() {
        this.Wz.setVisibility(8);
        try {
            ((InputMethodManager) getContext().getSystemService("input_method")).hideSoftInputFromWindow(this.Wz.getWindowToken(), 2);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    private void sz() {
        if (this.qw != null) {
            getRootView().getViewTreeObserver().removeOnGlobalLayoutListener(this.qw);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sA() {
        try {
            ((InputMethodManager) getContext().getSystemService("input_method")).showSoftInput(this.VA, 1);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
