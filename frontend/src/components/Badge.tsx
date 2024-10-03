interface BadgeProps {
  label: string;
}

export function Badge({ label }: BadgeProps) {
  return (
    <span className="px-2 py-1 rounded-full text-xs text-yellow-700 bg-yellow-300 font-bold uppercase">
      {label}
    </span>
  );
}
