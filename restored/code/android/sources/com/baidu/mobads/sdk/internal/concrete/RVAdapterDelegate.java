package com.baidu.mobads.sdk.internal.concrete;

import android.view.ViewGroup;
import androidx.recyclerview.widget.RecyclerView;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.baidu.mobads.sdk.internal.a.a;
import com.baidu.mobads.sdk.internal.a.b;
import com.baidu.mobads.sdk.internal.a.c;
import com.baidu.mobads.sdk.internal.widget.ViewPager2;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class RVAdapterDelegate extends RecyclerView.Adapter<RVViewHolderDelegate> implements a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final c f476a;
    private final b b;

    public RVAdapterDelegate(IAdInterListener iAdInterListener) {
        this.f476a = c.a(iAdInterListener, this);
        registerAdapterDataObserver(new ViewPager2.DataSetChangeObserver() { // from class: com.baidu.mobads.sdk.internal.concrete.RVAdapterDelegate.1
            @Override // com.baidu.mobads.sdk.internal.widget.ViewPager2.DataSetChangeObserver
            public void onChanged() {
                RVAdapterDelegate.this.f476a.a("onChanged");
            }
        });
        this.b = new b();
    }

    public RVViewHolderDelegate onCreateViewHolder(ViewGroup viewGroup, int i) {
        Object objA = this.f476a.a("onCreateViewHolder", viewGroup, Integer.valueOf(i));
        if (objA instanceof RVViewHolderDelegate) {
            return (RVViewHolderDelegate) objA;
        }
        return new RVViewHolderDelegate(this.f476a.getDelegator(), viewGroup) { // from class: com.baidu.mobads.sdk.internal.concrete.RVAdapterDelegate.2
        };
    }

    public void onBindViewHolder(RVViewHolderDelegate rVViewHolderDelegate, int i) {
        this.f476a.a("onBindViewHolder", rVViewHolderDelegate.getDelegator(), Integer.valueOf(i));
    }

    public int getItemCount() {
        Object objA = this.f476a.a("getItemCount", new Object[0]);
        if (objA instanceof Integer) {
            return ((Integer) objA).intValue();
        }
        return 0;
    }

    public long getItemId(int i) {
        Object objA = this.f476a.a("getItemId", Integer.valueOf(i));
        if (objA instanceof Integer) {
            return ((Integer) objA).intValue();
        }
        return super.getItemId(i);
    }

    public int getItemViewType(int i) {
        Object objA = this.f476a.a("getItemType", Integer.valueOf(i));
        if (objA instanceof Integer) {
            return ((Integer) objA).intValue();
        }
        return super.getItemViewType(i);
    }

    public void onViewRecycled(RVViewHolderDelegate rVViewHolderDelegate) {
        super.onViewRecycled(rVViewHolderDelegate);
        this.f476a.a("onViewRecycled", rVViewHolderDelegate.getDelegator());
    }

    public boolean onFailedToRecycleView(RVViewHolderDelegate rVViewHolderDelegate) {
        Object objA = this.f476a.a("onFailedToRecycleView", rVViewHolderDelegate.getDelegator());
        if (objA instanceof Boolean) {
            return ((Boolean) objA).booleanValue();
        }
        return super.onFailedToRecycleView(rVViewHolderDelegate);
    }

    public void onViewAttachedToWindow(RVViewHolderDelegate rVViewHolderDelegate) {
        super.onViewAttachedToWindow(rVViewHolderDelegate);
        this.f476a.a("onViewAttachedToWindow", rVViewHolderDelegate.getDelegator());
    }

    public void onViewDetachedFromWindow(RVViewHolderDelegate rVViewHolderDelegate) {
        super.onViewDetachedFromWindow(rVViewHolderDelegate);
        this.f476a.a("onViewDetachedFromWindow", rVViewHolderDelegate.getDelegator());
    }

    public void onAttachedToRecyclerView(RecyclerView recyclerView) {
        super.onAttachedToRecyclerView(recyclerView);
        this.f476a.a("onAttachedToRecyclerView", recyclerView);
    }

    public void onDetachedFromRecyclerView(RecyclerView recyclerView) {
        super.onDetachedFromRecyclerView(recyclerView);
        this.f476a.a("onDetachedFromRecyclerView", recyclerView);
    }

    @Override // com.baidu.mobads.sdk.internal.a.a
    public IAdInterListener getDelegator() {
        return this.f476a.getDelegator();
    }

    @Override // com.baidu.mobads.sdk.internal.a.a
    public Object handleEvent(String str, String str2, Object[] objArr) {
        if ("notifyItemChanged".equals(str2)) {
            notifyItemChanged(this.b.a(objArr, 0, 0), this.b.a(objArr, 1, (Object) null));
        } else if ("notifyRangeInserted".equals(str2)) {
            notifyItemRangeInserted(this.b.a(objArr, 0, 0), this.b.a(objArr, 1, 0));
        } else if ("notifyRangeRemoved".equals(str2)) {
            notifyItemRangeRemoved(this.b.a(objArr, 0, 0), this.b.a(objArr, 1, 0));
        } else if ("notifyItemRangeChanged".equals(str2)) {
            notifyItemRangeChanged(this.b.a(objArr, 0, 0), this.b.a(objArr, 1, 0));
        } else if ("notifyDataSetChanged".equals(str2)) {
            notifyDataSetChanged();
        }
        return null;
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public void setTarget(Object obj) {
        this.f476a.setTarget(obj);
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public Object getTarget() {
        return this.f476a.getTarget();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public String getType() {
        return this.f476a.getType();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public int getCode() {
        return this.f476a.getCode();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public String getMessage() {
        return this.f476a.getMessage();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public Map<String, Object> getData() {
        return this.f476a.getData();
    }
}
