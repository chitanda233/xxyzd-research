package com.byazt.sm;

import android.content.Context;
import android.graphics.Typeface;
import android.os.Build;
import android.text.TextUtils;
import androidx.core.view.GravityCompat;
import com.baidu.mobads.sdk.api.PrerollVideoResponse;
import com.byazt.cd.x;
import com.byazt.xj.ve;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 40, 13})
public class tt extends ve<UGTextView> {
    public int az;
    public String c;
    public int cf;

    @Deprecated
    public float di;
    public int ej;
    public float hg;
    public int ij;

    @Deprecated
    public TextUtils.TruncateAt is;
    public float iy;

    @Deprecated
    public float jg;
    public TextUtils.TruncateAt jt;
    public float k;
    public float kz;
    public int mq;
    public float nl;
    public boolean pl;
    public float sd;
    public int vi;
    public float vp;
    public float w;
    public int yo;

    public tt(Context context) {
        super(context);
        this.yo = -16777216;
        this.vp = 12.0f;
        this.kz = -1.0f;
        this.mq = Integer.MAX_VALUE;
        this.ij = GravityCompat.START;
        this.jt = TextUtils.TruncateAt.END;
        this.w = -1.0f;
        this.nl = 400.0f;
    }

    @Override // com.byazt.xj.ve
    /* JADX INFO: renamed from: sp, reason: merged with bridge method [inline-methods] */
    public UGTextView c() {
        UGTextView uGTextView = new UGTextView(this.tt);
        uGTextView.c(this);
        return uGTextView;
    }

    @Override // com.byazt.xj.ve
    public void tt() {
        super.tt();
        if (TextUtils.equals("null", this.c)) {
            this.c = "";
        }
        t(this.c);
        ((UGTextView) this.n).setTextSize(1, this.vp);
        ((UGTextView) this.n).setTextColor(this.yo);
        ((UGTextView) this.n).setLines(this.cf);
        ((UGTextView) this.n).setMaxLines(this.mq);
        ((UGTextView) this.n).setGravity(this.ij);
        ((UGTextView) this.n).setIncludeFontPadding(false);
        ((UGTextView) this.n).setMinTextSize(x.c(this.tt, this.kz));
        a(this.az);
        if (h()) {
            c(this.jt);
        } else {
            c(this.is);
        }
        if (this.w > 0.0f) {
            if (h()) {
                b();
            } else {
                x();
            }
        }
        ((UGTextView) this.n).setBreakStrategy(0);
        if (h()) {
            if (this.pl) {
                if (this.k <= 0.0f) {
                    this.k = 1.0E-5f;
                }
                ((UGTextView) this.n).setShadowLayer(this.k, this.hg, this.sd, this.ej);
            }
        } else {
            ((UGTextView) this.n).setShadowLayer(this.k, this.di, this.jg, this.ej);
        }
        if (this.vi == 1) {
            ((UGTextView) this.n).setTypeface(Typeface.DEFAULT, this.vi);
        } else if (Build.VERSION.SDK_INT >= 28) {
            ((UGTextView) this.n).setTypeface(Typeface.create(Typeface.DEFAULT, (int) this.nl, this.vi == 2));
        } else if (this.nl >= 500.0f) {
            ((UGTextView) this.n).setTypeface(Typeface.DEFAULT, 1);
        }
        if (x.c(this.tt, this.vp) > 0.0f) {
            ((UGTextView) this.n).setLetterSpacing(this.iy / x.c(this.tt, this.vp));
        }
    }

    private void x() {
        ((UGTextView) this.n).setLineSpacing(0.0f, this.w);
    }

    private void b() {
        if (this.w <= 3.0f) {
            ((UGTextView) this.n).setLineSpacing(0.0f, this.w);
            return;
        }
        if (Build.VERSION.SDK_INT >= 28) {
            int iRound = Math.round(x.c(this.tt, (this.w - (this.vp * 1.2f)) / 2.0f));
            ((UGTextView) this.n).setPadding(((UGTextView) this.n).getPaddingLeft(), ((UGTextView) this.n).getPaddingTop() + iRound, ((UGTextView) this.n).getPaddingRight(), ((UGTextView) this.n).getPaddingBottom() + iRound);
            ((UGTextView) this.n).setLineHeight(Math.round(x.c(this.tt, this.w)));
        }
    }

    public void t(String str) {
        this.c = str;
        if (TextUtils.isEmpty(str)) {
            return;
        }
        if (TextUtils.equals("null", str)) {
            this.c = "";
        }
        ((UGTextView) this.n).setText(this.c);
    }

    public void a(int i) {
        this.az = i;
        if (i == Integer.MAX_VALUE) {
            return;
        }
        ((UGTextView) this.n).setPaintFlags(i);
    }

    public void c(TextUtils.TruncateAt truncateAt) {
        if (truncateAt == null) {
            return;
        }
        ((UGTextView) this.n).setEllipsize(truncateAt);
    }

    @Override // com.byazt.xj.ve
    public void c(String str, String str2) {
        if (TextUtils.isEmpty(str)) {
        }
        super.c(str, str2);
        str.hashCode();
        switch (str) {
            case "shadowRadius":
            case "shadowBlur":
                this.k = com.byazt.cd.ve.c(str2, 0.0f);
                break;
            case "shadowColor":
                this.ej = com.byazt.cd.c.c(str2);
                this.pl = true;
                break;
            case "shadowOffsetX":
                this.hg = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
            case "shadowOffsetY":
                this.sd = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
            case "textAlign":
                this.ij = z(str2);
                break;
            case "textColor":
                this.yo = com.byazt.cd.c.c(str2);
                break;
            case "textStyle":
                this.vi = yp(str2);
                break;
            case "textSize":
                this.vp = com.byazt.cd.ve.c(str2, 0.0f);
                break;
            case "textDecoration":
                this.az = m(str2);
                break;
            case "shadowDx":
                this.di = com.byazt.cd.ve.c(str2, 0.0f);
                break;
            case "shadowDy":
                this.jg = com.byazt.cd.ve.c(str2, 0.0f);
                break;
            case "fontWeight":
                float fC = com.byazt.cd.ve.c(str2, -1.0f);
                this.nl = fC;
                if (fC < 1.0f || fC > 1000.0f) {
                    this.nl = 400.0f;
                    break;
                }
                break;
            case "lineHeight":
                this.w = com.byazt.cd.ve.c(str2, 1.0f);
                break;
            case "text":
                this.c = str2;
                break;
            case "lines":
                this.cf = com.byazt.cd.ve.c(str2, 0);
                break;
            case "ellipsis":
                this.jt = u(str2);
                break;
            case "minTextSize":
                this.kz = com.byazt.cd.ve.c(str2, -1.0f);
                break;
            case "maxLines":
                int iC = com.byazt.cd.ve.c(str2, Integer.MAX_VALUE);
                this.mq = iC > 0 ? iC : Integer.MAX_VALUE;
                break;
            case "ellipsize":
                this.is = sl(str2);
                break;
            case "letterSpacing":
                this.iy = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
        }
    }

    private TextUtils.TruncateAt sl(String str) {
        str.hashCode();
        switch (str) {
            case "center":
                this.is = TextUtils.TruncateAt.MIDDLE;
                break;
            case "end":
                this.is = TextUtils.TruncateAt.END;
                break;
            case "start":
                this.is = TextUtils.TruncateAt.START;
                break;
            default:
                this.is = null;
                break;
        }
        return this.is;
    }

    private TextUtils.TruncateAt u(String str) {
        if (TextUtils.equals(str, "none")) {
            return null;
        }
        return TextUtils.TruncateAt.END;
    }

    /* JADX WARN: Code duplicated, block: B:18:0x0035  */
    private int yp(String str) {
        byte b;
        int iHashCode = str.hashCode();
        if (iHashCode != -1178781136) {
            if (iHashCode != -1039745817) {
                if (iHashCode == 3029637 && str.equals("bold")) {
                    b = 0;
                } else {
                    b = -1;
                }
            } else if (str.equals(PrerollVideoResponse.NORMAL)) {
                b = 2;
            } else {
                b = -1;
            }
        } else if (str.equals("italic")) {
            b = 1;
        } else {
            b = -1;
        }
        if (b != 0) {
            return b != 1 ? 0 : 2;
        }
        return 1;
    }

    /* JADX WARN: Failed to restore switch over string. Please report as a decompilation issue */
    private int z(String str) {
        str.hashCode();
        byte b = -1;
        switch (str.hashCode()) {
            case -1364013995:
                if (str.equals("center")) {
                    b = 0;
                }
                break;
            case -348726240:
                if (str.equals("center_vertical")) {
                    b = 1;
                }
                break;
            case 3317767:
                if (str.equals("left")) {
                    b = 2;
                }
                break;
            case 108511772:
                if (str.equals("right")) {
                    b = 3;
                }
                break;
            case 1063616078:
                if (str.equals("center_horizontal")) {
                    b = 4;
                }
                break;
        }
        switch (b) {
            case 0:
                return 17;
            case 1:
                return 16;
            case 2:
            default:
                return 3;
            case 3:
                return 5;
            case 4:
                return 1;
        }
    }

    private int m(String str) {
        str.hashCode();
        switch (str) {
            case "underline":
                return 8;
            case "strikethrough":
                return 16;
            case "none":
            default:
                return Integer.MAX_VALUE;
        }
    }
}
