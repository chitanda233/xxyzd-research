package com.byazt.sz;

import android.animation.AnimatorSet;
import android.animation.ArgbEvaluator;
import android.animation.ObjectAnimator;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.AccelerateDecelerateInterpolator;
import android.view.animation.AccelerateInterpolator;
import android.view.animation.DecelerateInterpolator;
import android.view.animation.LinearInterpolator;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SUB, 67})
public class u {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f1427a;
    public Paint c;
    public int n;
    public String sp;
    public c tt;
    public View uj;
    public AnimatorSet ve = new AnimatorSet();

    public u(View view, c cVar) {
        this.uj = view;
        this.tt = cVar;
        Paint paint = new Paint();
        this.c = paint;
        paint.setAntiAlias(true);
    }

    public void c() {
        ArrayList arrayList = new ArrayList();
        List<c.C0245c> listVe = this.tt.ve();
        if (listVe == null || listVe.size() <= 0) {
            return;
        }
        for (c.C0245c c0245c : listVe) {
            if (c0245c != null) {
                ObjectAnimator objectAnimator = new ObjectAnimator();
                objectAnimator.setDuration(c0245c.c());
                if (TextUtils.equals(c0245c.getType(), "translateX")) {
                    objectAnimator.setPropertyName("translationX");
                } else if (TextUtils.equals(c0245c.getType(), "translateY")) {
                    objectAnimator.setPropertyName("translationY");
                } else {
                    objectAnimator.setPropertyName(c0245c.getType());
                }
                objectAnimator.setStartDelay(c0245c.uj());
                objectAnimator.setTarget(this.uj);
                if (TextUtils.equals(c0245c.getType(), "backgroundColor")) {
                    objectAnimator.setIntValues((int) c0245c.n(), (int) c0245c.a());
                } else {
                    objectAnimator.setFloatValues(c0245c.n(), c0245c.a());
                }
                int iTt = (int) this.tt.tt();
                if (iTt != 0) {
                    objectAnimator.setRepeatCount(iTt);
                } else {
                    objectAnimator.setRepeatCount((int) c0245c.tt());
                }
                if (TextUtils.equals(c0245c.getType(), "backgroundColor")) {
                    objectAnimator.setEvaluator(new ArgbEvaluator());
                }
                String strA = this.tt.a();
                if (TextUtils.isEmpty(strA)) {
                    strA = c0245c.ve();
                }
                if (TextUtils.equals(strA, "reverse")) {
                    objectAnimator.setRepeatMode(2);
                } else {
                    objectAnimator.setRepeatMode(1);
                }
                if (c0245c.sp() != null && c0245c.sp().length > 0) {
                    objectAnimator.setFloatValues(c0245c.sp());
                }
                if (TextUtils.equals(c0245c.getType(), "rotationX")) {
                    this.uj.post(new Runnable() { // from class: com.byazt.sz.u.1
                        @Override // java.lang.Runnable
                        public void run() {
                            u.this.uj.setPivotX(u.this.uj.getWidth() / 2.0f);
                            u.this.uj.setPivotY(u.this.uj.getHeight());
                        }
                    });
                }
                if (TextUtils.equals(c0245c.getType(), "ripple")) {
                    this.sp = c0245c.i();
                }
                String strX = c0245c.x();
                strX.hashCode();
                switch (strX) {
                    case "accelerate":
                        objectAnimator.setInterpolator(new AccelerateInterpolator());
                        break;
                    case "decelerate":
                        objectAnimator.setInterpolator(new DecelerateInterpolator());
                        break;
                    case "linear":
                    case "standard":
                        objectAnimator.setInterpolator(new LinearInterpolator());
                        break;
                    case "accelerateDecelerate":
                        objectAnimator.setInterpolator(new AccelerateDecelerateInterpolator());
                        break;
                }
                arrayList.add(objectAnimator);
            }
        }
        if (this.tt.uj() != 0) {
            this.ve.setDuration(this.tt.uj());
        }
        this.ve.setStartDelay(this.tt.n());
        if (TextUtils.equals(this.tt.c(), "sequentially")) {
            this.ve.playSequentially(arrayList);
        } else {
            this.ve.playTogether(arrayList);
        }
        this.ve.start();
    }

    public void tt() {
        AnimatorSet animatorSet = this.ve;
        if (animatorSet != null) {
            animatorSet.cancel();
        }
    }

    public void c(Canvas canvas, n nVar) {
        try {
            if (nVar.getRipple() == 0.0f || TextUtils.isEmpty(this.sp)) {
                return;
            }
            this.c.setColor(com.byazt.cd.c.c(this.sp));
            this.c.setAlpha(90);
            ((ViewGroup) this.uj.getParent()).setClipChildren(true);
            int i = this.n;
            int i2 = this.f1427a;
            canvas.drawCircle(i, i2, Math.min(i, i2) * 2 * nVar.getRipple(), this.c);
        } catch (Throwable th) {
            th.getMessage();
        }
    }

    public void c(int i, int i2) {
        this.n = i / 2;
        this.f1427a = i2 / 2;
    }
}
