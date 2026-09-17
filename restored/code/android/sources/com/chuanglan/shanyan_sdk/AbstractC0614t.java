package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.text.SpannableStringBuilder;
import android.text.TextPaint;
import android.text.TextUtils;
import android.text.method.LinkMovementMethod;
import android.text.style.ClickableSpan;
import android.text.style.ForegroundColorSpan;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.chuanglan.shanyan_sdk.listener.AuthPageActionListener;
import com.chuanglan.shanyan_sdk.listener.OnClickPrivacyListener;
import com.chuanglan.shanyan_sdk.listener.PricacyOnClickListener;
import com.chuanglan.shanyan_sdk.tool.ConfigPrivacyBean;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.t, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0614t {

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.t$a */
    class a implements View.OnClickListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2000a;
        final /* synthetic */ String b;
        final /* synthetic */ String c;
        final /* synthetic */ String d;
        final /* synthetic */ ShanYanUIConfig e;
        final /* synthetic */ Context f;

        a(int i, String str, String str2, String str3, ShanYanUIConfig shanYanUIConfig, Context context) {
            this.f2000a = i;
            this.b = str;
            this.c = str2;
            this.d = str3;
            this.e = shanYanUIConfig;
            this.f = context;
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            try {
                OnClickPrivacyListener onClickPrivacyListener = AbstractC0606l.Q;
                if (onClickPrivacyListener != null) {
                    onClickPrivacyListener.getOnClickPrivacyStatus(this.f2000a, "" + this.b, this.c);
                }
                AuthPageActionListener authPageActionListener = AbstractC0606l.S;
                if (authPageActionListener != null) {
                    authPageActionListener.setAuthPageActionListener(1, this.f2000a, this.b + "|" + this.c);
                }
                PricacyOnClickListener pricacyOnClickListener = AbstractC0606l.R;
                if (pricacyOnClickListener != null) {
                    pricacyOnClickListener.onClick(this.d, this.b);
                }
                if (this.e.isPrivacyActivityEnabled()) {
                    AbstractC0595a.a(this.f, this.d, this.b);
                }
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "clickableSpan1 Exception_e=", e);
            }
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.t$b */
    static class b extends ClickableSpan {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final boolean f2001a;
        private final View.OnClickListener b;

        public b(boolean z, View.OnClickListener onClickListener) {
            this.f2001a = z;
            this.b = onClickListener;
        }

        @Override // android.text.style.ClickableSpan
        public void onClick(View view) {
            this.b.onClick(view);
            if (view instanceof TextView) {
                ((TextView) view).setHighlightColor(0);
            }
        }

        @Override // android.text.style.ClickableSpan, android.text.style.CharacterStyle
        public void updateDrawState(TextPaint textPaint) {
            super.updateDrawState(textPaint);
            try {
                if (this.f2001a) {
                    textPaint.setUnderlineText(true);
                } else {
                    textPaint.setUnderlineText(false);
                }
                textPaint.setColor(0);
                textPaint.clearShadowLayer();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public static void a(ShanYanUIConfig shanYanUIConfig, Context context, TextView textView, View view, String str) {
        SpannableStringBuilder spannableStringBuilder;
        SpannableStringBuilder spannableStringBuilder2 = null;
        try {
            try {
                int clauseColor = shanYanUIConfig.getClauseColor();
                int clauseBaseColor = shanYanUIConfig.getClauseBaseColor();
                ArrayList arrayList = new ArrayList();
                List<ConfigPrivacyBean> morePrivacy = shanYanUIConfig.getMorePrivacy();
                if (shanYanUIConfig.isOperatorPrivacyAtLast()) {
                    if (morePrivacy != null) {
                        arrayList.addAll(morePrivacy);
                    }
                    arrayList.add(new ConfigPrivacyBean(AbstractC0606l.n, AbstractC0606l.o, clauseColor));
                } else {
                    arrayList.add(new ConfigPrivacyBean(AbstractC0606l.n, AbstractC0606l.o, clauseColor));
                    if (morePrivacy != null) {
                        arrayList.addAll(morePrivacy);
                    }
                    ((ConfigPrivacyBean) arrayList.get(0)).setMidStr(shanYanUIConfig.getPrivacyTextMidOne());
                }
                spannableStringBuilder = new SpannableStringBuilder(a(shanYanUIConfig, arrayList).toString());
                int i = 0;
                while (i < arrayList.size()) {
                    try {
                        String name = shanYanUIConfig.isPrivacySmhHidden() ? ((ConfigPrivacyBean) arrayList.get(i)).getName() : "《" + ((ConfigPrivacyBean) arrayList.get(i)).getName() + "》";
                        int color = ((ConfigPrivacyBean) arrayList.get(i)).getColor();
                        String url = ((ConfigPrivacyBean) arrayList.get(i)).getUrl();
                        a(spannableStringBuilder, name, color == 0 ? clauseColor : color, shanYanUIConfig.isPrivacyNameUnderline(), new a(i, (shanYanUIConfig.getPrivacyTitleArray() == null || shanYanUIConfig.getPrivacyTitleArray().length <= i) ? ((ConfigPrivacyBean) arrayList.get(i)).getTitle() : shanYanUIConfig.getPrivacyTitleArray()[i], str, url, shanYanUIConfig, context));
                        i++;
                        clauseColor = clauseColor;
                        arrayList = arrayList;
                    } catch (Exception e) {
                        e = e;
                        spannableStringBuilder2 = spannableStringBuilder;
                        e.printStackTrace();
                        if (spannableStringBuilder2 != null) {
                            spannableStringBuilder2.clear();
                            spannableStringBuilder2.clearSpans();
                            return;
                        }
                        return;
                    } catch (Throwable th) {
                        th = th;
                        if (spannableStringBuilder != null) {
                            spannableStringBuilder.clear();
                            spannableStringBuilder.clearSpans();
                        }
                        throw th;
                    }
                }
                a(context, view, shanYanUIConfig);
                textView.setMovementMethod(LinkMovementMethod.getInstance());
                textView.setTextColor(clauseBaseColor);
                textView.setHighlightColor(0);
                if (shanYanUIConfig.isPrivacyOffsetGravityLeft()) {
                    textView.setGravity(3);
                } else {
                    textView.setGravity(17);
                }
                textView.setText(spannableStringBuilder);
                spannableStringBuilder.clear();
                spannableStringBuilder.clearSpans();
            } catch (Exception e2) {
                e = e2;
            }
        } catch (Throwable th2) {
            th = th2;
            spannableStringBuilder = spannableStringBuilder2;
        }
    }

    private static StringBuilder a(ShanYanUIConfig shanYanUIConfig, List list) {
        StringBuilder sb = new StringBuilder();
        sb.append(shanYanUIConfig.getPrivacyTextHead());
        for (int i = 0; i < list.size(); i++) {
            sb.append(shanYanUIConfig.isPrivacySmhHidden() ? ((ConfigPrivacyBean) list.get(i)).getName() : "《" + ((ConfigPrivacyBean) list.get(i)).getName() + "》");
            if (i < list.size() - 1) {
                sb.append(((ConfigPrivacyBean) list.get(i)).getMidStr());
            }
        }
        sb.append(shanYanUIConfig.getPrivacyTextEnd());
        return sb;
    }

    private static void a(Context context, View view, ShanYanUIConfig shanYanUIConfig) {
        int privacyOffsetY = shanYanUIConfig.getPrivacyOffsetY();
        int privacyOffsetBottomY = shanYanUIConfig.getPrivacyOffsetBottomY();
        int privacyOffsetX = shanYanUIConfig.getPrivacyOffsetX();
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = -2;
        layoutParams.height = -2;
        ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams(layoutParams);
        int iA = a(context, privacyOffsetY);
        int iA2 = a(context, privacyOffsetBottomY);
        float f = privacyOffsetX;
        int iA3 = a(context, f);
        double d = privacyOffsetX;
        if (d == -1.0d && privacyOffsetY == -1.0d) {
            marginLayoutParams.setMargins(0, 0, 0, iA2);
        } else if (d != -1.0d && privacyOffsetY == -1.0d) {
            marginLayoutParams.setMargins(iA3, 0, 0, iA2);
        } else if (d == -1.0d && privacyOffsetY != -1.0d) {
            marginLayoutParams.setMargins(0, iA, 0, 0);
        } else if (d != -1.0d && privacyOffsetY != -1.0d) {
            marginLayoutParams.setMargins(iA3, iA, 0, 0);
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(marginLayoutParams);
        if (d == -1.0d && privacyOffsetY == -1.0d) {
            layoutParams2.leftMargin = AbstractC0597c.a(context, 40.0f);
            layoutParams2.rightMargin = AbstractC0597c.a(context, 60.0f);
            layoutParams2.addRule(12);
            layoutParams2.addRule(14);
        } else if (d != -1.0d && privacyOffsetY == -1.0d) {
            layoutParams2.leftMargin = AbstractC0597c.a(context, f);
            layoutParams2.rightMargin = AbstractC0597c.a(context, f);
            layoutParams2.addRule(12);
            if (shanYanUIConfig.isPrivacyGravityHorizontalCenter()) {
                layoutParams2.addRule(14);
            } else {
                layoutParams2.addRule(9);
            }
        } else if (d == -1.0d && privacyOffsetY != -1.0d) {
            layoutParams2.leftMargin = AbstractC0597c.a(context, 40.0f);
            layoutParams2.rightMargin = AbstractC0597c.a(context, 60.0f);
            layoutParams2.addRule(10);
            layoutParams2.addRule(14);
        } else if (d != -1.0d && privacyOffsetY != -1.0d) {
            layoutParams2.leftMargin = AbstractC0597c.a(context, f);
            layoutParams2.rightMargin = AbstractC0597c.a(context, f);
            layoutParams2.addRule(10);
            if (shanYanUIConfig.isPrivacyGravityHorizontalCenter()) {
                layoutParams2.addRule(14);
            } else {
                layoutParams2.addRule(9);
            }
        }
        if (shanYanUIConfig.getPrivacyWidth() != -1) {
            layoutParams2.width = AbstractC0597c.a(context, shanYanUIConfig.getPrivacyWidth());
        }
        view.setLayoutParams(layoutParams2);
    }

    private static int a(Context context, float f) {
        return (int) ((f * context.getResources().getDisplayMetrics().density) + 0.5f);
    }

    static void a(SpannableStringBuilder spannableStringBuilder, String str, int i, boolean z, View.OnClickListener onClickListener) {
        int iIndexOf;
        if (TextUtils.isEmpty(spannableStringBuilder) || TextUtils.isEmpty(str) || (iIndexOf = spannableStringBuilder.toString().indexOf(str)) < 0) {
            return;
        }
        int length = str.length() + iIndexOf;
        spannableStringBuilder.setSpan(new b(z, onClickListener), iIndexOf, length, 17);
        spannableStringBuilder.setSpan(new ForegroundColorSpan(i), iIndexOf, length, 17);
    }
}
