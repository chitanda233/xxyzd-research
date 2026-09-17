package com.kwad.components.ad.widget;

import android.content.Context;
import android.text.SpannableString;
import android.text.TextUtils;
import android.text.style.AbsoluteSizeSpan;
import android.text.style.ForegroundColorSpan;
import android.text.style.StrikethroughSpan;
import android.util.AttributeSet;
import android.widget.TextView;
import com.kwad.components.core.widget.d;
import com.kwad.components.core.widget.e;
import com.kwad.sdk.R;
import com.kwad.sdk.core.d.c;

/* JADX INFO: loaded from: classes3.dex */
public class KsPriceView extends TextView implements d {
    private static String Od = "¥%s 到手约 ¥%s";
    private static String Oe = "¥%s  ¥%s";
    private static String Of = "¥%s";
    private a Oc;
    private String Og;
    private String Oh;
    private boolean Oi;

    public KsPriceView(Context context) {
        super(context);
        this.Oc = new a();
        A(context);
    }

    public KsPriceView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.Oc = new a();
        A(context);
    }

    public KsPriceView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.Oc = new a();
        A(context);
    }

    public KsPriceView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.Oc = new a();
        A(context);
    }

    private void A(Context context) {
        setMaxLines(1);
        this.Oc.Ol = context.getResources().getColor(R.color.ksad_reward_main_color);
        this.Oc.Om = context.getResources().getDimensionPixelSize(R.dimen.ksad_reward_order_price_size);
        this.Oc.On = context.getResources().getColor(R.color.ksad_reward_original_price);
        this.Oc.Oo = context.getResources().getDimensionPixelSize(R.dimen.ksad_reward_order_original_price_size);
        this.Oc.Oj = context.getResources().getColor(R.color.ksad_reward_main_color);
        this.Oc.Ok = context.getResources().getDimensionPixelSize(R.dimen.ksad_reward_order_price_size);
    }

    public a getConfig() {
        return this.Oc;
    }

    public final void h(String str, String str2) {
        d(str, str2, false);
    }

    public final void d(String str, String str2, boolean z) {
        if (TextUtils.isEmpty(str) && TextUtils.isEmpty(str2)) {
            return;
        }
        this.Og = str;
        this.Oh = str2;
        this.Oi = z;
        SpannableString spannableStringA = null;
        if (TextUtils.isEmpty(str2)) {
            this.Oh = null;
        }
        if (str != null && str.startsWith("¥")) {
            str = str.replaceFirst("¥", "");
        }
        setTextColor(this.Oc.ot());
        try {
            spannableStringA = a(str, this.Oh, z, this.Oc);
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
        if (spannableStringA != null) {
            setText(spannableStringA);
        }
    }

    private static SpannableString a(String str, String str2, boolean z, a aVar) {
        String str3;
        if (str2 == null) {
            str3 = String.format(Of, str);
        } else {
            str3 = String.format(z ? Oe : Od, str, str2);
        }
        SpannableString spannableString = new SpannableString(str3);
        if (str3.startsWith("¥")) {
            spannableString.setSpan(new ForegroundColorSpan(aVar.ox()), 0, 1, 17);
            spannableString.setSpan(new AbsoluteSizeSpan(aVar.oy()), 0, 1, 17);
        }
        int iIndexOf = str3.indexOf(str);
        if (iIndexOf < 0) {
            return null;
        }
        int length = str.length() + iIndexOf;
        spannableString.setSpan(new ForegroundColorSpan(aVar.ot()), iIndexOf, length, 18);
        spannableString.setSpan(new AbsoluteSizeSpan(aVar.ov()), iIndexOf, length, 18);
        if (str2 != null) {
            int iLastIndexOf = str3.lastIndexOf(str2) - 1;
            int length2 = str2.length() + 1 + iLastIndexOf;
            spannableString.setSpan(new ForegroundColorSpan(aVar.ou()), iLastIndexOf, length2, 18);
            spannableString.setSpan(new AbsoluteSizeSpan(aVar.ow()), iLastIndexOf, length2, 18);
            spannableString.setSpan(new StrikethroughSpan(), iLastIndexOf, length2, 18);
        }
        return spannableString;
    }

    @Override // com.kwad.components.core.widget.d
    public final void a(e eVar) {
        this.Oc.Ol = eVar.Aj();
        d(this.Og, this.Oh, this.Oi);
    }

    public static class a {
        private int Oj;
        private int Ok;
        private int Ol;
        private int Om;
        private int On;
        private int Oo;

        public final int ot() {
            return this.Ol;
        }

        public final int ou() {
            return this.On;
        }

        public final int ov() {
            return this.Om;
        }

        public final int ow() {
            return this.Oo;
        }

        public final int ox() {
            return this.Oj;
        }

        public final int oy() {
            return this.Ok;
        }

        public final a au(int i) {
            this.Ok = i;
            return this;
        }

        public final a av(int i) {
            this.On = i;
            return this;
        }

        public final a aw(int i) {
            this.Oo = i;
            return this;
        }
    }
}
